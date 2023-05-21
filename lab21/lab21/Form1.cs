using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace lab21
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
            Save.Enabled = false;
        }
        string title = "Untitled ";

        private void New_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = title + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        private int openDocuments = 0;
        private object tbPaste;

        private void Cascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Paste();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = new blank();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
                Save.Enabled = true;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Save(frm.DocName);
            frm.IsSaved = true;
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            Save.Enabled = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)this.ActiveMdiChild;
                frm.Save(saveFileDialog.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog.FileName;
                frm.Text = frm.DocName;
                frm.IsSaved = true;
            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            fontDialog1.ShowColor = true;
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            frm.Show();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            FindForm frm = new FindForm();
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            blank form = (blank)this.ActiveMdiChild;
            form.MdiParent = this;
            int start = form.richTextBox1.SelectionStart;
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
        }

        private void AboutProgramm_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Equals(tbNew))
            {
                New_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbOpen))
            {
                Open_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbSave))
            {
                Save_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbCut))
            {
                Cut_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbCopy))
            {
                Copy_Click(this, new EventArgs());
            }
            if (e.ClickedItem.Equals(tbPaste))
            {
                Paste_Click(this, new EventArgs());
            }

        }
        private void Left_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            frm.Show();
        }

        private void Center_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            frm.Show();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            frm.Show();
        }
    }
}
