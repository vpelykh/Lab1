namespace lab21
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFind = new System.Windows.Forms.TextBox();
            this.MatchCase = new System.Windows.Forms.CheckBox();
            this.MatchWhole = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(9, 8);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(192, 22);
            this.txtFind.TabIndex = 0;
            // 
            // MatchCase
            // 
            this.MatchCase.AutoSize = true;
            this.MatchCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatchCase.Location = new System.Drawing.Point(9, 42);
            this.MatchCase.Name = "MatchCase";
            this.MatchCase.Size = new System.Drawing.Size(94, 19);
            this.MatchCase.TabIndex = 2;
            this.MatchCase.Text = "Match &Case";
            this.MatchCase.UseVisualStyleBackColor = true;
            // 
            // MatchWhole
            // 
            this.MatchWhole.AutoSize = true;
            this.MatchWhole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatchWhole.Location = new System.Drawing.Point(120, 36);
            this.MatchWhole.Name = "MatchWhole";
            this.MatchWhole.Size = new System.Drawing.Size(99, 34);
            this.MatchWhole.TabIndex = 3;
            this.MatchWhole.Text = "Match &whole\r\nword";
            this.MatchWhole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MatchWhole.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(235, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cance";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 83);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.MatchWhole);
            this.Controls.Add(this.MatchCase);
            this.Controls.Add(this.txtFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        public System.Windows.Forms.CheckBox MatchCase;
        public System.Windows.Forms.CheckBox MatchWhole;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Button btnCancel;
    }
}