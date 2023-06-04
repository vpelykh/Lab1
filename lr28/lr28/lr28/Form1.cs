using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;
namespace lr28
{
    public partial class Form1 : Form
    {
        private string currentDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory.FullName;
                node.Nodes.Add(new TreeNode());
                treeView1.Nodes.Add(node);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            TreeNode node = treeView1.SelectedNode;
            if (node.Nodes.Count == 1 && node.Nodes[0].Tag == null)
            {
                node.Nodes.Clear();

                string path = node.Tag.ToString();
                DirectoryInfo directory = new DirectoryInfo(path);
                try
                {
                    foreach (DirectoryInfo subdirectory in directory.GetDirectories())
                    {
                        TreeNode subnode = new TreeNode(subdirectory.Name);
                        subnode.Tag = subdirectory.FullName;
                        subnode.Nodes.Add(new TreeNode());
                        node.Nodes.Add(subnode);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access denied.");
                }

                foreach (FileInfo file in directory.GetFiles())
                {
                    TreeNode subnode = new TreeNode(file.Name);
                    subnode.Tag = file.FullName;
                    node.Nodes.Add(subnode);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            TreeNode node = treeView1.SelectedNode;
            if (node.Tag != null)
            {
                currentDirectory = node.Tag.ToString();
                DirectoryInfo directory = new DirectoryInfo(currentDirectory);
                try
                {
                    foreach (DirectoryInfo subdirectory in directory.GetDirectories())
                    {
                        ListViewItem item = new ListViewItem(subdirectory.Name);
                        item.SubItems.Add("Folder");
                        item.SubItems.Add(subdirectory.LastWriteTime.ToString());
                        item.Tag = subdirectory.FullName;
                        listView1.Items.Add(item);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access denied.");
                }

                foreach (FileInfo file in directory.GetFiles())
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add(file.LastWriteTime.ToString());
                    item.Tag = file.FullName;
                    listView1.Items.Add(item);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
            {
                return;
            }
            string path = listView1.SelectedItems[0].Tag.ToString();
            FileInfo file = new FileInfo(path);
            if (file.Extension == ".txt")
            {
                OpenTextFile(path);
            }
            else if (IsImageFile(file.Extension))
            {
                OpenImageFile(path);
            }
            else
            {
                MessageBox.Show("Unsupported file type.");
            }
        }

        private void OpenImageFile(string path)
        {
            throw new NotImplementedException();
        }

        private bool IsImageFile(string extension)
        {
            throw new NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filter = textBox1.Text.ToLower();

            foreach (ListViewItem item in listView1.Items)
            {
                string name = item.Text.ToLower();
                if (name.Contains(filter))
                {
                    item.ForeColor = SystemColors.WindowText;
                    item.BackColor = SystemColors.Window;
                }
                else
                {
                    item.ForeColor = SystemColors.GrayText;
                    item.BackColor = SystemColors.Control;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string path = listView1.SelectedItems[0].Tag.ToString();
                FileSystemSecurity security = null;
                if (Directory.Exists(path))
                {
                    DirectoryInfo directory = new DirectoryInfo(path);
                    security = directory.GetAccessControl();
                }
                else if (File.Exists(path))
                {
                    FileInfo file = new FileInfo(path);
                    security = file.GetAccessControl();
                }
                if (security != null)
                {
                    SecurityForm form = new SecurityForm();
                    form.DisplaySecurity(security);
                    form.ShowDialog();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenTextFile(openFileDialog.FileName);
            }
        }
        private void OpenTextFile(string fileName)
        {
            throw new NotImplementedException();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenImageFile(openFileDialog.FileName);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string directoryPath = textBox2.Text;

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                MessageBox.Show("Каталог було успішно створено.");
            }
            else
            {
                MessageBox.Show("Каталог вже існує.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sourceDirectoryPath = textBox3.Text;
            string destinationDirectoryPath = textBox4.Text;

            if (Directory.Exists(sourceDirectoryPath))
            {
                Directory.Move(sourceDirectoryPath, destinationDirectoryPath);
                MessageBox.Show("Каталог було успішно переміщено.");
            }
            else
            {
                MessageBox.Show("Каталог не знайдено.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count <= 0)
            {
                return;
            }
            string path = listView1.SelectedItems[0].Tag.ToString();
            FileInfo file = new FileInfo(path);
            if (file.Extension == ".txt")
            {
                OpenTextFile(path);
            }
            else if (IsImageFile(file.Extension))
            {
                OpenImageFile(path);
            }
            else
            {
                MessageBox.Show("Unsupported file type.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string directoryPath = textBox2.Text;

            if (Directory.Exists(directoryPath))
            {
                Directory.Delete(directoryPath, true);
                MessageBox.Show("Каталог було успішно видалено.");
            }
            else
            {
                MessageBox.Show("Каталог не знайдено.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string filePath = textBox5.Text;

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                MessageBox.Show("Файл було успішно створено.");
            }
            else
            {
                MessageBox.Show("Файл вже існує.");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string sourceFilePath = textBox6.Text;
            string destinationFilePath = textBox7.Text;

            if (File.Exists(sourceFilePath))
            {
                File.Move(sourceFilePath, destinationFilePath);
                MessageBox.Show("Файл було успішно переміщено.");
            }
            else
            {
                MessageBox.Show("Файл не знайдено.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string sourceFilePath = textBox6.Text;
            string destinationFilePath = textBox7.Text;

            if (File.Exists(sourceFilePath))
            {
                File.Copy(sourceFilePath, destinationFilePath, true);
                MessageBox.Show("Файл було успішно скопійовано.");
            }
            else
            {
                MessageBox.Show("Файл не знайдено.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string filePath = textBox5.Text;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                MessageBox.Show("Файл було успішно видалено.");
            }
            else
            {
                MessageBox.Show("Файл не знайдено.");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string filePath = textBox5.Text;

            if (File.Exists(filePath))
            {
                FileAttributes attributes = File.GetAttributes(filePath);

                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {

                    attributes &= ~FileAttributes.ReadOnly;
                    File.SetAttributes(filePath, attributes);
                    MessageBox.Show("Атрибут \"тільки для читання\" було успішно знято з файлу.");
                }
                else
                {

                    attributes |= FileAttributes.ReadOnly;
                    File.SetAttributes(filePath, attributes);
                    MessageBox.Show("Атрибут \"тільки для читання\" було успішно додано до файлу.");
                }
            }
            else
            {
                MessageBox.Show("Файл не знайдено.");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string directoryPath = textBox2.Text;

            if (Directory.Exists(directoryPath))
            {
                FileAttributes attributes = File.GetAttributes(directoryPath);

                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {

                    attributes &= ~FileAttributes.Hidden;
                    File.SetAttributes(directoryPath, attributes);
                    MessageBox.Show("Атрибут \"прихований\" було успішно знято з каталогу.");
                }
                else
                {

                    attributes |= FileAttributes.Hidden;
                    File.SetAttributes(directoryPath, attributes);
                    MessageBox.Show("Атрибут \"прихований\" було успішно додано до каталогу.");
                }
            }
            else
            {
                MessageBox.Show("Каталог не знайдено.");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string filePath = textBox5.Text;

            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);


                TextEditorForm textEditorForm = new TextEditorForm(text);
                DialogResult result = textEditorForm.ShowDialog();

                if (result == DialogResult.OK)
                {

                    string editedText = textEditorForm.GetText();
                    File.WriteAllText(filePath, editedText);
                    MessageBox.Show("Файл було успішно збережено.");
                }
            }
            else
            {
                MessageBox.Show("Файл не знайдено.");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string sourceDirectoryPath = textBox3.Text;
            string zipFilePath = textBox8.Text;

            ZipFile.CreateFromDirectory(sourceDirectoryPath, zipFilePath);
            MessageBox.Show("Архів було успішно створено.");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string zipFilePath = textBox8.Text;
            string destinationDirectoryPath = textBox3.Text;

            ZipFile.ExtractToDirectory(zipFilePath, destinationDirectoryPath);
            MessageBox.Show("Файли було успішно розпаковано.");
        }
    }
    class SecurityForm
    {
        private FileSystemSecurity security;

        public SecurityForm()
        {
        }

        public SecurityForm(FileSystemSecurity security)
        {
            this.security = security;
        }

        internal void DisplaySecurity(FileSystemSecurity security)
        {
            throw new NotImplementedException();
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }

    class TextEditorForm
    {
        public TextEditorForm(string text)
        {
            Text = text;
        }

        public string Text { get; }

        internal string GetText()
        {
            throw new NotImplementedException();
        }

        internal DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }
    }

    class ZipFile
    {
        internal static void CreateFromDirectory(string sourceDirectoryPath, string zipFilePath)
        {
            throw new NotImplementedException();
        }

        internal static void ExtractToDirectory(string zipFilePath, string destinationDirectoryPath)
        {
            throw new NotImplementedException();
        }
    }
}
