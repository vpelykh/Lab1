using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;

            Stack<char> stack = new Stack<char>();
            bool isCorrect = true;

            foreach (char c in expression)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        isCorrect = false;
                        break;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }

            if (stack.Count > 0)
            {
                isCorrect = false;
            }

            if (isCorrect)
            {
                MessageBox.Show("Дужки розставлені правильно");
            }
            else
            {
                MessageBox.Show("Дужки розставлені неправильно");
            }
        }
    }
}
