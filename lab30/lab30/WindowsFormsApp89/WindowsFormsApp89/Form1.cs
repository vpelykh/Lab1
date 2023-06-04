using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp89
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            FadList.Items.Clear();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);


            while (!reader.EndOfStream)
            {
                FadList.Items.Add(reader.ReadLine());

            }
            MessageBox.Show(response.WelcomeMessage);
            reader.Close();
            response.Close();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*|PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|BMP files (*.bmp)|*.bmp|EXE files (*.exe)|*.exe|RAR files (*.rar)|*.rar|ZIP files (*.zip)|*.zip|TXT files (*.txt)|*.txt";

            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text +
               tbUpload.Text + openFileDialog1.SafeFileName);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                byte[] file = File.ReadAllBytes(textBox1.Text);
                Stream strz = request.GetRequestStream();
                strz.Write(file, 0, file.Length);
                strz.Close();
                strz.Dispose();

                MessageBox.Show(openFileDialog1.SafeFileName + "завантажено");
            }
            else
            {
                MessageBox.Show(openFileDialog1.SafeFileName + "Не заватажено");
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text +
tbNewDir.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Каталог " + tbNewDir.Text + "створено");

        }

        private void appe_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + openFileDialog1.SafeFileName);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.AppendFile;

                using (Stream fileStream = openFileDialog1.OpenFile())
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                }

                MessageBox.Show(openFileDialog1.SafeFileName + " appended");
            }
        }

        private void dele_Click(object sender, EventArgs e)
        {
            string fileName = FadList.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fileName))
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + fileName);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show(fileName + " deleted");

                response.Close();
            }
        }

        private void retr_Click(object sender, EventArgs e)
        {
            string fileName = FadList.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fileName))
            {
                saveFileDialog1.Filter = "All files (*.*)|*.*";
                saveFileDialog1.FileName = fileName;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + fileName);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.DownloadFile;

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    using (Stream ftpStream = response.GetResponseStream())
                    using (Stream fileStream = File.Create(saveFileDialog1.FileName))
                    {
                        ftpStream.CopyTo(fileStream);
                    }

                    MessageBox.Show(fileName + " downloaded");
                }
            }
        }

        private void mdt_Click(object sender, EventArgs e)
        {
            string fileName = FadList.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fileName))
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + fileName);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.GetDateTimestamp;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show("Modification Time of " + fileName + ": " + response.LastModified);

                response.Close();
            }
        }

        private void size_Click(object sender, EventArgs e)
        {
            string fileName = FadList.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fileName))
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + fileName);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.GetFileSize;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show("Size of " + fileName + ": " + response.ContentLength + " bytes");

                response.Close();
            }
        }

        private void nlist_Click(object sender, EventArgs e)
        {
            FadList.Items.Clear();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    FadList.Items.Add(line);
                }
            }

            MessageBox.Show("NLIST completed");
        }

        private void list_Click(object sender, EventArgs e)
        {
            FadList.Items.Clear();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    FadList.Items.Add(line);
                }
            }

            MessageBox.Show("LIST completed");
        }

        private void mkd_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbNewDir.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Directory " + tbNewDir.Text + " created");

            response.Close();
        }

        private void rmd_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbRemoveDir.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.RemoveDirectory;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Directory " + tbRemoveDir.Text + " removed");

            response.Close();
        }

        private void rename_Click(object sender, EventArgs e)
        {
            string oldFileName = FadList.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(oldFileName) && !string.IsNullOrEmpty(tbNewName.Text))
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + oldFileName);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.Rename;
                request.RenameTo = tbNewName.Text;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show(oldFileName + " renamed to " + tbNewName.Text);

                response.Close();
            }
        }

        private void stor_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + openFileDialog1.SafeFileName);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                using (Stream fileStream = openFileDialog1.OpenFile())
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                }

                MessageBox.Show(openFileDialog1.SafeFileName + " uploaded");
            }
        }

        private void stou_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.UploadFileWithUniqueName;
                using (Stream fileStream = openFileDialog1.OpenFile())
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                }

                MessageBox.Show("File uploaded with a unique name");
            }
        }
    }
}
