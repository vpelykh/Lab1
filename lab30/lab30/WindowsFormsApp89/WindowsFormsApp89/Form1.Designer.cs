
namespace WindowsFormsApp89
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.tbRemoveDir = new System.Windows.Forms.TextBox();
            this.stou = new System.Windows.Forms.Button();
            this.stor = new System.Windows.Forms.Button();
            this.rename = new System.Windows.Forms.Button();
            this.rmd = new System.Windows.Forms.Button();
            this.mkd = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.nlist = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.Button();
            this.mdt = new System.Windows.Forms.Button();
            this.retr = new System.Windows.Forms.Button();
            this.dele = new System.Windows.Forms.Button();
            this.appe = new System.Windows.Forms.Button();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbNewDir = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUpload = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.FadList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(514, 294);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(225, 22);
            this.tbNewName.TabIndex = 47;
            // 
            // tbRemoveDir
            // 
            this.tbRemoveDir.Location = new System.Drawing.Point(514, 341);
            this.tbRemoveDir.Name = "tbRemoveDir";
            this.tbRemoveDir.Size = new System.Drawing.Size(225, 22);
            this.tbRemoveDir.TabIndex = 46;
            // 
            // stou
            // 
            this.stou.Location = new System.Drawing.Point(213, 342);
            this.stou.Name = "stou";
            this.stou.Size = new System.Drawing.Size(171, 30);
            this.stou.TabIndex = 45;
            this.stou.Text = "stou";
            this.stou.UseVisualStyleBackColor = true;
            this.stou.Click += new System.EventHandler(this.stou_Click);
            // 
            // stor
            // 
            this.stor.Location = new System.Drawing.Point(213, 290);
            this.stor.Name = "stor";
            this.stor.Size = new System.Drawing.Size(171, 30);
            this.stor.TabIndex = 44;
            this.stor.Text = "stor";
            this.stor.UseVisualStyleBackColor = true;
            this.stor.Click += new System.EventHandler(this.stor_Click);
            // 
            // rename
            // 
            this.rename.Location = new System.Drawing.Point(213, 228);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(171, 30);
            this.rename.TabIndex = 43;
            this.rename.Text = "rename";
            this.rename.UseVisualStyleBackColor = true;
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // rmd
            // 
            this.rmd.Location = new System.Drawing.Point(213, 179);
            this.rmd.Name = "rmd";
            this.rmd.Size = new System.Drawing.Size(171, 30);
            this.rmd.TabIndex = 42;
            this.rmd.Text = "rmd";
            this.rmd.UseVisualStyleBackColor = true;
            this.rmd.Click += new System.EventHandler(this.rmd_Click);
            // 
            // mkd
            // 
            this.mkd.Location = new System.Drawing.Point(213, 133);
            this.mkd.Name = "mkd";
            this.mkd.Size = new System.Drawing.Size(171, 30);
            this.mkd.TabIndex = 41;
            this.mkd.Text = "mkd";
            this.mkd.UseVisualStyleBackColor = true;
            this.mkd.Click += new System.EventHandler(this.mkd_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(213, 81);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(171, 30);
            this.list.TabIndex = 40;
            this.list.Text = "list";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // nlist
            // 
            this.nlist.Location = new System.Drawing.Point(213, 35);
            this.nlist.Name = "nlist";
            this.nlist.Size = new System.Drawing.Size(171, 30);
            this.nlist.TabIndex = 39;
            this.nlist.Text = "nlist";
            this.nlist.UseVisualStyleBackColor = true;
            this.nlist.Click += new System.EventHandler(this.nlist_Click);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(12, 390);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(171, 30);
            this.size.TabIndex = 38;
            this.size.Text = "size";
            this.size.UseVisualStyleBackColor = true;
            this.size.Click += new System.EventHandler(this.size_Click);
            // 
            // mdt
            // 
            this.mdt.Location = new System.Drawing.Point(12, 333);
            this.mdt.Name = "mdt";
            this.mdt.Size = new System.Drawing.Size(171, 30);
            this.mdt.TabIndex = 37;
            this.mdt.Text = "mdt";
            this.mdt.UseVisualStyleBackColor = true;
            this.mdt.Click += new System.EventHandler(this.mdt_Click);
            // 
            // retr
            // 
            this.retr.Location = new System.Drawing.Point(12, 279);
            this.retr.Name = "retr";
            this.retr.Size = new System.Drawing.Size(171, 30);
            this.retr.TabIndex = 36;
            this.retr.Text = "retr";
            this.retr.UseVisualStyleBackColor = true;
            this.retr.Click += new System.EventHandler(this.retr_Click);
            // 
            // dele
            // 
            this.dele.Location = new System.Drawing.Point(12, 228);
            this.dele.Name = "dele";
            this.dele.Size = new System.Drawing.Size(171, 28);
            this.dele.TabIndex = 35;
            this.dele.Text = "dele";
            this.dele.UseVisualStyleBackColor = true;
            this.dele.Click += new System.EventHandler(this.dele_Click);
            // 
            // appe
            // 
            this.appe.Location = new System.Drawing.Point(12, 179);
            this.appe.Name = "appe";
            this.appe.Size = new System.Drawing.Size(171, 33);
            this.appe.TabIndex = 34;
            this.appe.Text = "appe";
            this.appe.UseVisualStyleBackColor = true;
            this.appe.Click += new System.EventHandler(this.appe_Click);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(514, 202);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(225, 22);
            this.tbHost.TabIndex = 33;
            // 
            // tbNewDir
            // 
            this.tbNewDir.Location = new System.Drawing.Point(514, 247);
            this.tbNewDir.Name = "tbNewDir";
            this.tbNewDir.Size = new System.Drawing.Size(225, 22);
            this.tbNewDir.TabIndex = 32;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(514, 153);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(225, 22);
            this.tbPass.TabIndex = 31;
            // 
            // tbUpload
            // 
            this.tbUpload.Location = new System.Drawing.Point(514, 109);
            this.tbUpload.Name = "tbUpload";
            this.tbUpload.Size = new System.Drawing.Size(225, 22);
            this.tbUpload.TabIndex = 30;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(514, 70);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(225, 22);
            this.tbUser.TabIndex = 29;
            // 
            // FadList
            // 
            this.FadList.FormattingEnabled = true;
            this.FadList.ItemHeight = 16;
            this.FadList.Location = new System.Drawing.Point(799, 70);
            this.FadList.Name = "FadList";
            this.FadList.Size = new System.Drawing.Size(229, 68);
            this.FadList.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 27;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(12, 132);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(171, 33);
            this.create.TabIndex = 26;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(12, 79);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(171, 32);
            this.upload.TabIndex = 25;
            this.upload.Text = "upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(12, 30);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(171, 35);
            this.connect.TabIndex = 24;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "textBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "tbUser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "tbUpload";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "tbPass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "tbHost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "tbNewDir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "tbNewName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "tbRemoveDir";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 667);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.tbRemoveDir);
            this.Controls.Add(this.stou);
            this.Controls.Add(this.stor);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.rmd);
            this.Controls.Add(this.mkd);
            this.Controls.Add(this.list);
            this.Controls.Add(this.nlist);
            this.Controls.Add(this.size);
            this.Controls.Add(this.mdt);
            this.Controls.Add(this.retr);
            this.Controls.Add(this.dele);
            this.Controls.Add(this.appe);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.tbNewDir);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUpload);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.FadList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.create);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.TextBox tbRemoveDir;
        private System.Windows.Forms.Button stou;
        private System.Windows.Forms.Button stor;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.Button rmd;
        private System.Windows.Forms.Button mkd;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.Button nlist;
        private System.Windows.Forms.Button size;
        private System.Windows.Forms.Button mdt;
        private System.Windows.Forms.Button retr;
        private System.Windows.Forms.Button dele;
        private System.Windows.Forms.Button appe;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbNewDir;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUpload;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.ListBox FadList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

