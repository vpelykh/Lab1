using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp56
{
    public partial class Form1 : Form
    {
        private FractionCalculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new FractionCalculator();
        }
        public class Fraction
        {
            private int numerator; 
            private int denominator;
            public Fraction(int numerator, int denominator)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
            public int Numerator
            {
                get { return numerator; }
                set { numerator = value; }
            }
            public int Denominator
            {
                get { return denominator; }
                set { denominator = value; }
            }
          
            public void Reduce()
            {
                int gcd = Gcd(numerator, denominator);
                numerator /= gcd;
                denominator /= gcd;
            }
           
            public void Power(int n)
            {
                numerator = (int)Math.Pow(numerator, n);
                denominator = (int)Math.Pow(denominator, n);
            }
           
            public double ToDecimal()
            {
                return (double)numerator / denominator;
            }
 
            public override string ToString()
            {
                return string.Format("{0}/{1}", numerator, denominator);
            }
          
            private static int Gcd(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }
          
            public static Fraction operator +(Fraction a, Fraction b)
            {
                int newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
                int newDenominator = a.denominator * b.denominator;
                return new Fraction(newNumerator, newDenominator);
            }
       
            public static Fraction operator -(Fraction a, Fraction b)
            {
                int newNumerator = a.numerator * b.denominator - b.numerator * a.denominator;
                int newDenominator = a.denominator * b.denominator;
                return new Fraction(newNumerator, newDenominator);
            }
        
            public static Fraction operator *(Fraction a, Fraction b)
            {
                int newNumerator = a.numerator * b.numerator;
                int newDenominator = a.denominator * b.denominator;
                return new Fraction(newNumerator, newDenominator);
            }
     
            public static Fraction operator /(Fraction a, Fraction b)
            {
                int newNumerator = a.numerator * b.denominator;
                int newDenominator = a.denominator * b.numerator;
                return new Fraction(newNumerator, newDenominator);
            }
          
            public static bool operator ==(Fraction a, Fraction b)
            {
                return a.numerator * b.denominator == b.numerator * a.denominator;
            }
            public static bool operator !=(Fraction a, Fraction b)
            {
                return !(a == b);
            }
            public static bool operator >=(Fraction a, Fraction b)
            {
                return a.numerator * b.denominator >= b.numerator * a.denominator;
            }
            public static bool operator <=(Fraction a, Fraction b)
            {
                return a.numerator * b.denominator <= b.numerator * a.denominator;
            }
            public static bool operator >(Fraction a, Fraction b)
            {
                return a.numerator * b.denominator > b.numerator * a.denominator;
            }
            public static bool operator <(Fraction a, Fraction b)
            {
                return a.numerator * b.denominator < b.numerator * a.denominator;
            }
        }
        
        public class FractionCalculator
        {
            private List<Fraction> fractions; 
            public FractionCalculator()
            {
                fractions = new List<Fraction>();
            }
            public void AddFraction(int numerator, int denominator)
            {
                Fraction fraction = new Fraction(numerator, denominator);
                fractions.Add(fraction);
            }
            public Fraction Sum()
            {
                Fraction result = new Fraction(0, 1);
                foreach (Fraction fraction in fractions)
                {
                    result += fraction;
                }
                return result;
            }
            public Fraction Average()
            {
                Fraction sum = Sum();
                int count = fractions.Count;
                Fraction result = new Fraction(sum.Numerator, sum.Denominator * count);
                return result;
            }
            public void ReduceFraction(int index)
            {
                Fraction fraction = fractions[index];
                fraction.Reduce();
            }
            public void PowerFraction(int index, int n)
            {
                Fraction fraction = fractions[index];
                fraction.Power(n);
            }
            public void DeleteFraction(int index)
            {
                fractions.RemoveAt(index);
            }
            public void ClearFractions()
            {
                fractions.Clear();
            }
            public int Count()
            {
                return fractions.Count;
            }
            public Fraction GetFraction(int index)
            {
                return fractions[index];
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                foreach (Fraction fraction in fractions)
                {
                    sb.AppendLine(fraction.ToString());
                }
                return sb.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numerator = (int)numericUpDown1.Value;
            int denominator = (int)numericUpDown2.Value;
            calculator.AddFraction(numerator, denominator);
            listBox1.Items.Add(calculator.GetFraction(calculator.Count() - 1).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fraction sum = calculator.Sum();
            textBox1.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fraction average = calculator.Average();
            textBox1.Text = average.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                calculator.ReduceFraction(index);
                listBox1.Items[index] = calculator.GetFraction(index).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            int n = (int)numericUpDown3.Value;
            if (index != -1)
            {
                calculator.PowerFraction(index, n);
                listBox1.Items[index] = calculator.GetFraction(index).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                calculator.DeleteFraction(index);
                listBox1.Items.RemoveAt(index);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calculator.ClearFractions();
            listBox1.Items.Clear();
            textBox1.Text = string.Empty;
        }
    }
}
