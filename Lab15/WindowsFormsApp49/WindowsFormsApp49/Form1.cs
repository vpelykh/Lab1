using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] serviceTimesStr = textBox1.Text.Split(' ');
            int[] serviceTimes = new int[serviceTimesStr.Length];

            for (int i = 0; i < serviceTimesStr.Length; i++)
            {
                serviceTimes[i] = Convert.ToInt32(serviceTimesStr[i]);
            }

            int[] waitTimes = new int[serviceTimes.Length];
            int totalWaitTime = 0;

            for (int i = 0; i < serviceTimes.Length; i++)
            {
                waitTimes[i] = totalWaitTime;
                totalWaitTime += serviceTimes[i];
            }

            string result = string.Join(", ", waitTimes);
            textBox2.Text = $"Час перебування в черзі: {result}";
        }
    }
}
