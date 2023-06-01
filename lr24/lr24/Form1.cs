using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(draw_rect));
            thread2 = new Thread(new ThreadStart(draw_eclips));
            thread3 = new Thread(new ThreadStart(Rnd_num));
        }
        Thread thread1;
        Thread thread2;
        Thread thread3;
        private void draw_rect()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel1.Creategraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawRectangle(Pens.Pink, 0, 0, rnd.Next(this.Width),
                    rnd.Next(this.Height));
                }
            }
            catch (Exception) { }
        }
        private void draw_eclips()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel2.Creategraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawEllipse(Pens.Pink, 0, 0, rnd.Next(this.Width),
                   rnd.Next(this.Height));
                }
            }
            catch (Exception) { }
        }
        private void Rnd_num()
        {
            try
            {
                Random rnd = new Random();
                Parallel.For(0, 500, i =>
                {
                    richTextBox.Invoke((MethodInvoker)delegate ()
                    {
                        richTextBox.Text += rnd.Next().ToString();
                    });
                });
            }
            catch (Exception ex) { Messagebox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread1.Start();
            //draw_rect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thread2.Start();
            //draw_eclips();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thread3.Start();
            //Rnd_num();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thread2.Suspend();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            thread3.Suspend();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }
        class Messagebox
        {
            internal static void Show(string message)
            {
                throw new NotImplementedException();
            }
        }

        class Formclosedeventargs
        {
        }

        class panel1
        {
            internal static Graphics Creategraphics()
            {
                throw new NotImplementedException();
            }
        }

        class panel2
        {
            internal static Graphics Creategraphics()
            {
                throw new NotImplementedException();
            }
        }
    }
}
