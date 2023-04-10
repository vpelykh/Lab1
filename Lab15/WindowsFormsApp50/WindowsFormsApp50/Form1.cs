using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = textBox1.Text;
            string[] words = inputString.Split(' ');
            List<string> resultWords = new List<string>();

            foreach (string word in words)
            {
                if (word.Contains('k'))
                {
                    resultWords.Add(word);
                }
            }

            string result = string.Join(", ", resultWords);
            textBox2.Text = $"Слова, які містять букву k: {result}";
        }
    }
}
