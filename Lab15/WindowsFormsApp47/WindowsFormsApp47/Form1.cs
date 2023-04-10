using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            if (a == 0 && b == 0) 
            {
                textBox3.Text = "Рівняння має безліч розв'язків";
            }
            else if (a == 0) 
            {
                double x = -b / a;
                textBox3.Text = $"x = {x}";
            }
            else 
            {
                double delta = b * b - 4 * a * 0;
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = -b / (2 * a);
                double x3 = (-b - Math.Sqrt(delta)) / (2 * a);
                textBox3.Text = $"x1 = {x1}, x2 = {x2}, x3 = {x3}";
            }
        }
    }
}
