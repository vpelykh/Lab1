using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            List<int> numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                bool isDivisibleByDigits = true;

                while (number > 0)
                {
                    int digit = number % 10;

                    if (digit != 0 && i % digit != 0)
                    {
                        isDivisibleByDigits = false;
                        break;
                    }

                    number /= 10;
                }

                if (isDivisibleByDigits)
                {
                    numbers.Add(i);
                }
            }

            string result = string.Join(", ", numbers);
            textBox2.Text = $"Числа, які діляться на кожну зі своїх цифр: {result}";
        }
    }
}
