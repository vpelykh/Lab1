using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp55
{
    public partial class Form1 : Form
    {
        private double[,] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int n) || !int.TryParse(textBox2.Text, out int m))
            {
                MessageBox.Show("Розмірність масиву введено невірно!");
                return;
            }

            array = new double[n, m];

           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!double.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out double value))
                    {
                        MessageBox.Show($"Елемент масиву з індексами [{i},{j}] введено невірно!");
                        return;
                    }
                    array[i, j] = value;
                }
            }

            
            int x1 = int.Parse(textBox3.Text);
            int y1 = int.Parse(textBox4.Text);
            int x2 = int.Parse(textBox5.Text);
            int y2 = int.Parse(textBox6.Text);
            double difference = array[x1, y1] - array[x2, y2];
            textBox7.Text = $"Різниця між елементами з індексами [{x1},{y1}] та [{x2},{y2}]: {difference}";

         
            double product = array[x1, y1] * array[x2, y2];
            double geometricMean = Math.Sqrt(product);
            textBox8.Text = $"Середнє геометричне елементів з індексами [{x1},{y1}] та [{x2},{y2}]: {geometricMean}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            textBox7.Text = "";
            textBox8.Text = "";
        }

      
    }
}
