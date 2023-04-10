using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Norm
        {
            public abstract double NormValue();
            public abstract double Modulus();
        }
        public class Complex : Norm
        {
            private double real;
            private double imag;

            public Complex(double real, double imag)
            {
                this.real = real;
                this.imag = imag;
            }

            public override double NormValue()
            {
                return real * real + imag * imag;
            }

            public override double Modulus()
            {
                return Math.Sqrt(real * real + imag * imag);
            }
        }
        public class Vector3D : Norm
        {
            private double x;
            private double y;
            private double z;

            public Vector3D(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public override double NormValue()
            {
                return Math.Max(Math.Abs(x), Math.Max(Math.Abs(y), Math.Abs(z)));
            }

            public override double Modulus()
            {
                return Math.Sqrt(x * x + y * y + z * z);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double realPart = double.Parse(textBox1.Text);
            double imaginaryPart = double.Parse(textBox2.Text);

            // Створюємо об'єкт комплексного числа
            Complex complex = new Complex(realPart, imaginaryPart);

            // Обчислюємо модуль та норму комплексного числа
            double modulus = complex.Modulus();
            double norm = complex.NormValue();

            // Виводимо результати у текстові поля
            textBox3.Text = modulus.ToString();
            textBox4.Text = norm.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }
    }
}
