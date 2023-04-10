using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] inputArray = textBox1.Text.Split();

        
            double[] array = new double[inputArray.Length];

            
            for (int i = 0; i < inputArray.Length; i++)
            {
                double.TryParse(inputArray[i], out array[i]);
            }

            
            double[] transformedArray = new double[array.Length];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    transformedArray[j] = array[i];
                    j += 2;
                }
            }
            j = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    transformedArray[j] = array[i];
                    j += 2;
                }
            }

            
            double maxElement = transformedArray[0];
            int maxElementIndex = 0;
            for (int i = 1; i < transformedArray.Length; i++)
            {
                if (transformedArray[i] > maxElement)
                {
                    maxElement = transformedArray[i];
                    maxElementIndex = i;
                }
            }

            
            double product = 1;
            int firstZeroIndex = Array.IndexOf(transformedArray, 0);
            if (firstZeroIndex != -1)
            {
                int secondZeroIndex = Array.IndexOf(transformedArray, 0, firstZeroIndex + 1);
                if (secondZeroIndex != -1)
                {
                    for (int i = firstZeroIndex + 1; i < secondZeroIndex; i++)
                    {
                        product *= transformedArray[i];
                    }
                }
            }

           
            textBox2.Text = string.Join(" ", transformedArray);
            textBox3.Text = (maxElementIndex + 1).ToString();
            textBox4.Text = product.ToString();
        }
    }
}
