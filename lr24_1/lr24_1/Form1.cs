using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr24_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string inputFile = textBox1.Text;
            string outputFile = textBox2.Text;

            await Task.Run(() =>
            {
                try
                {
                    byte[] key = GenerateRandomKey(16); // Генеруємо випадковий ключ довжиною 16 байт

                    using (FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                    {
                        using (FileStream outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                        {
                            Cast5Engine cipher = new Cast5Engine();
                            KeyParameter keyParam = new KeyParameter(key);

                            cipher.Init(true, keyParam); // Ініціалізуємо шифр з ключем

                            byte[] inputBuffer = new byte[cipher.GetBlockSize()];
                            byte[] outputBuffer = new byte[cipher.GetBlockSize()];

                            int inputLength = 0;
                            int outputLength = 0;

                            while ((inputLength = inputStream.Read(inputBuffer, 0, inputBuffer.Length)) > 0)
                            {
                                outputLength = cipher.ProcessBlock(inputBuffer, 0, inputLength, outputBuffer, 0);
                                outputStream.Write(outputBuffer, 0, outputLength);
                            }
                        }
                    }

                    MessageBox.Show("Шифрування CAST завершено успішно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка під час шифрування: " + ex.Message);
                }
            });
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string inputFile = textBox1.Text;
            string outputFile = textBox2.Text;

            await Task.Run(() =>
            {
                try
                {
                    using (FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                    {
                        using (FileStream outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                        {
                            MD4Digest digest = new MD4Digest();
                            byte[] inputBuffer = new byte[1024];
                            byte[] outputBuffer = new byte[1024];

                            int inputLength = 0;
                            int outputLength = 0;

                            while ((inputLength = inputStream.Read(inputBuffer, 0, inputBuffer.Length)) > 0)
                            {
                                digest.BlockUpdate(inputBuffer, 0, inputLength);
                                outputStream.Write(inputBuffer, 0, inputLength);
                            }

                            byte[] hash = new byte[digest.GetDigestSize()];
                            digest.DoFinal(hash, 0);

                            string hashFile = Path.ChangeExtension(outputFile, "md4");
                            File.WriteAllBytes(hashFile, hash);
                        }
                    }

                    MessageBox.Show("Шифрування MD4 завершено успішно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка під час шифрування: " + ex.Message);
                }
            });
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string inputFile = textBox1.Text;
            string outputFile = textBox2.Text;

            await Task.Run(() =>
            {
                try
                {
                    byte[] key = GenerateRandomKey(16); // Генеруємо випадковий ключ довжиною 16 байт

                    using (FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                    {
                        using (FileStream outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                        {
                            SealEngine sealEngine = new SealEngine();
                            ISealEngine cipher = (ISealEngine)sealEngine;
                            KeyParameter keyParam = new KeyParameter(key);

                            cipher.Init(true, keyParam); // Ініціалізуємо шифр з ключем

                            byte[] inputBuffer = new byte[cipher.GetBlockSize()];
                            byte[] outputBuffer = new byte[cipher.GetBlockSize()];

                            int inputLength = 0;
                            int outputLength = 0;

                            while ((inputLength = inputStream.Read(inputBuffer, 0, inputBuffer.Length)) > 0)
                            {
                                outputLength = cipher.ProcessBlock(inputBuffer, 0, inputLength, outputBuffer, 0);
                                outputStream.Write(outputBuffer, 0, outputLength);
                            }
                        }
                    }

                    MessageBox.Show("Шифрування SEAL завершено успішно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка під час шифрування: " + ex.Message);
                }
            });
        }
        private byte[] GenerateRandomKey(int length)
        {
            byte[] key = new byte[length];
            SecureRandom random = new SecureRandom();
            random.NextBytes(key);
            return key;
        }

        private interface ISealEngine
        {
            int GetBlockSize();
            void Init(bool v, KeyParameter keyParam);
            int ProcessBlock(byte[] inputBuffer, int v1, int inputLength, byte[] outputBuffer, int v2);
        }
    }

    internal class KeyParameter
    {
        private byte[] key;

        public KeyParameter(byte[] key)
        {
            this.key = key;
        }
    }

    internal class SealEngine
    {
        public SealEngine()
        {
        }
    }

    class SecureRandom
    {
        internal void NextBytes(byte[] key)
        {
            throw new NotImplementedException();
        }
    }

    class Cast5Engine
    {
        internal int GetBlockSize()
        {
            throw new NotImplementedException();
        }

        internal void Init(bool v, KeyParameter keyParam)
        {
            throw new NotImplementedException();
        }

        internal int ProcessBlock(byte[] inputBuffer, int v1, int inputLength, byte[] outputBuffer, int v2)
        {
            throw new NotImplementedException();
        }
    }

    class MD4Digest
    {
        internal void BlockUpdate(byte[] inputBuffer, int v, int inputLength)
        {
            throw new NotImplementedException();
        }

        internal void DoFinal(byte[] hash, int v)
        {
            throw new NotImplementedException();
        }

        internal int GetDigestSize()
        {
            throw new NotImplementedException();
        }
    }
}
