using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr23
{
    public partial class Form1 : Form
    {
        private const float minX = -10f;
        private const float maxX = 10f;
        private const float minY = -10f;
        private const float maxY = 10f;

        private float R;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Встановлення початкового значення R
            R = 1.0f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримання значення R з введеного користувачем
            R = float.Parse(textBox1.Text);

            // Створення нового бітмапу для малювання графіку
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Малювання системи координат
                DrawCoordinateSystem(g);

                // Малювання графіку
                DrawGraph(g);
            }

            // Відображення графіку у PictureBox
            pictureBox1.Image = bitmap;
        }
        private void DrawCoordinateSystem(Graphics g)
        {
            // Визначення розмірів PictureBox
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            // Обчислення масштабу для перетворення координат
            float scaleX = width / (maxX - minX);
            float scaleY = height / (maxY - minY);

            // Малювання осей X та Y
            Pen axisPen = Pens.Black;
            g.DrawLine(axisPen, 0, height / 2, width, height / 2); // Ось X
            g.DrawLine(axisPen, width / 2, 0, width / 2, height); // Ось Y

            // Малювання підписів на осях
            Font font = new Font("Arial", 8);
            SolidBrush brush = new SolidBrush(Color.Black);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            // Підписи на осі X
            for (float x = minX; x <= maxX; x++)
            {
                int pixelX = (int)((x - minX) * scaleX);
                g.DrawString(x.ToString(), font, brush, pixelX, height / 2, format);
            }

            // Підписи на осі Y
            for (float y = minY; y <= maxY; y++)
            {
                int pixelY = height - (int)((y - minY) * scaleY);
                g.DrawString(y.ToString(), font, brush, width / 2, pixelY, format);
            }
        }

        private void DrawGraph(Graphics g)
        {
            // Визначення розмірів PictureBox
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            // Обчислення масштабу для перетворення координат
            float scaleX = width / (maxX - minX);
            float scaleY = height / (maxY - minY);

            // Малювання графіку за параметричними рівняннями
            Pen graphPen = new Pen(Color.Red);

            for (float t = minX; t <= maxX; t += 0.01f)
            {
                // Обчислення координат x та y для кожної точки
                float m = t / R;
                float x = (R - m * R) * (float)Math.Cos(m * t) + m * (float)Math.Cos(t - m * t);
                float y = (R - m * R) * (float)Math.Sin(m * t) - m * (float)Math.Sin(t - m * t);

                // Перетворення координат до розмірів PictureBox
                int pixelX = (int)((x - minX) * scaleX);
                int pixelY = height - (int)((y - minY) * scaleY);

                // Малювання точки на графіку
                g.DrawRectangle(graphPen, pixelX, pixelY, 1, 1);
            }
        }
    }
    }

