using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double circumference = Convert.ToDouble(textBox1.Text);
            double radius = circumference / (2 * Math.PI);
            double area = Math.PI * Math.Pow(radius, 2);

            textBox2.Text = area.ToString();
        }
    }
}
