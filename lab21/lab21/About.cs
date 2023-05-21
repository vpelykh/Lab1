using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab21
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        public string msg = "Unable to open link that was clicked.";

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + msg);
            }

        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.notepadcsharp.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
