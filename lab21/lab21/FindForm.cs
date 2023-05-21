using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab21
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        public RichTextBoxFinds FindCondition
        {
            get
            {
                if (MatchCase.Checked && MatchWhole.Checked)
                {
                    return RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord;
                }
                if (MatchCase.Checked)
                {
                    return RichTextBoxFinds.MatchCase;
                }
                if (MatchWhole.Checked)
                {
                    return RichTextBoxFinds.WholeWord;
                }
                return RichTextBoxFinds.None;
            }
        }

        public string FindText
        {
            get { return txtFind.Text; }
            set { txtFind.Text = value; }
        }
    }
}
