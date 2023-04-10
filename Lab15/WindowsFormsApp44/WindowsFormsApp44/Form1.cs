using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text); 

            double result = Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - (7 * x / (Math.Pow(x, 3) - 15 * x)); 

            textBox2.Text = $"Результат: {result}"; 
        }
    }
}
