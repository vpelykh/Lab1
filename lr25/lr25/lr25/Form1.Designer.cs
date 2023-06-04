namespace lr25
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnTrain = new Button();
            btnRoutes = new Button();
            label1 = new Label();
            btnAddRoutes = new Button();
            btnAddTrain = new Button();
            label2 = new Label();
            btnFindByName = new Button();
            label3 = new Label();
            name = new TextBox();
            town_txt = new TextBox();
            label4 = new Label();
            btnFindByTown = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnRoutesByDate = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            nameCarriage = new TextBox();
            label9 = new Label();
            label10 = new Label();
            town = new TextBox();
            label11 = new Label();
            Year = new TextBox();
            nameTrainAct = new TextBox();
            label12 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 252);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(908, 278);
            dataGridView1.TabIndex = 1;
            // 
            // btnTrain
            // 
            btnTrain.Location = new Point(936, 275);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(193, 29);
            btnTrain.TabIndex = 2;
            btnTrain.Text = "Вивести поїзди";
            btnTrain.UseVisualStyleBackColor = true;
            btnTrain.Click += btnTrain_Click;
            // 
            // btnRoutes
            // 
            btnRoutes.Location = new Point(936, 310);
            btnRoutes.Name = "btnRoutes";
            btnRoutes.Size = new Size(193, 29);
            btnRoutes.TabIndex = 3;
            btnRoutes.Text = "Вивести рухи";
            btnRoutes.UseVisualStyleBackColor = true;
            btnRoutes.Click += btnRoutes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(949, 366);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 6;
            label1.Text = "Вивід рухів в період";
            // 
            // btnAddRoutes
            // 
            btnAddRoutes.Location = new Point(477, 130);
            btnAddRoutes.Name = "btnAddRoutes";
            btnAddRoutes.Size = new Size(429, 35);
            btnAddRoutes.TabIndex = 36;
            btnAddRoutes.Text = "Додати рух";
            btnAddRoutes.Click += btnAddRoutes_Click;
            // 
            // btnAddTrain
            // 
            btnAddTrain.Location = new Point(12, 130);
            btnAddTrain.Name = "btnAddTrain";
            btnAddTrain.Size = new Size(429, 35);
            btnAddTrain.TabIndex = 37;
            btnAddTrain.Text = "Додати поїзд";
            btnAddTrain.Click += btnAddTrain_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 11;
            label2.Text = "Додати поїзд";
            // 
            // btnFindByName
            // 
            btnFindByName.Location = new Point(369, 182);
            btnFindByName.Name = "btnFindByName";
            btnFindByName.Size = new Size(73, 29);
            btnFindByName.TabIndex = 12;
            btnFindByName.Text = "Знайти";
            btnFindByName.UseVisualStyleBackColor = true;
            btnFindByName.Click += btnFindByName_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(175, 20);
            label3.TabIndex = 13;
            label3.Text = "Знайти поїзд за назвою";
            // 
            // name
            // 
            name.Location = new Point(238, 182);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 14;
            // 
            // town_txt
            // 
            town_txt.Location = new Point(237, 215);
            town_txt.Name = "town_txt";
            town_txt.Size = new Size(125, 27);
            town_txt.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 218);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 16;
            label4.Text = "вивести поїзди міста";
            // 
            // btnFindByTown
            // 
            btnFindByTown.Location = new Point(369, 213);
            btnFindByTown.Name = "btnFindByTown";
            btnFindByTown.Size = new Size(73, 29);
            btnFindByTown.TabIndex = 15;
            btnFindByTown.Text = "Знайти";
            btnFindByTown.UseVisualStyleBackColor = true;
            btnFindByTown.Click += btnFindByTown_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 9);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 18;
            label5.Text = "Додати рух поїзду";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(477, 35);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 20;
            label6.Text = "Назва поїзду";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(935, 399);
            label7.Name = "label7";
            label7.Size = new Size(16, 20);
            label7.TabIndex = 21;
            label7.Text = "з";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(936, 432);
            label8.Name = "label8";
            label8.Size = new Size(27, 20);
            label8.TabIndex = 22;
            label8.Text = "по";
            // 
            // btnRoutesByDate
            // 
            btnRoutesByDate.Location = new Point(936, 460);
            btnRoutesByDate.Name = "btnRoutesByDate";
            btnRoutesByDate.Size = new Size(194, 29);
            btnRoutesByDate.TabIndex = 23;
            btnRoutesByDate.Text = "Вивести рухи";
            btnRoutesByDate.UseVisualStyleBackColor = true;
            btnRoutesByDate.Click += btnRoutesByDate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(969, 394);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(116, 27);
            dateTimePicker1.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(969, 427);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(116, 27);
            dateTimePicker2.TabIndex = 25;
            // 
            // nameCarriage
            // 
            nameCarriage.Location = new Point(162, 32);
            nameCarriage.Name = "nameCarriage";
            nameCarriage.Size = new Size(280, 27);
            nameCarriage.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 35);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 27;
            label9.Text = "Назва поїзду";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 67);
            label10.Name = "label10";
            label10.Size = new Size(149, 20);
            label10.TabIndex = 28;
            label10.Text = "Місто виготовлення";
            // 
            // town
            // 
            town.Location = new Point(193, 64);
            town.Name = "town";
            town.Size = new Size(249, 27);
            town.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 100);
            label11.Name = "label11";
            label11.Size = new Size(129, 20);
            label11.TabIndex = 30;
            label11.Text = "Рік виготовлення";
            // 
            // Year
            // 
            Year.Location = new Point(162, 97);
            Year.Name = "Year";
            Year.Size = new Size(64, 27);
            Year.TabIndex = 31;
            // 
            // nameTrainAct
            // 
            nameTrainAct.Location = new Point(626, 32);
            nameTrainAct.Name = "nameTrainAct";
            nameTrainAct.Size = new Size(280, 27);
            nameTrainAct.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(477, 67);
            label12.Name = "label12";
            label12.Size = new Size(104, 20);
            label12.TabIndex = 33;
            label12.Text = "Виберіть дату";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(626, 64);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(118, 27);
            dateTimePicker3.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1002, 252);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 35;
            label13.Text = "Таблиці";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 542);
            Controls.Add(label13);
            Controls.Add(dateTimePicker3);
            Controls.Add(label12);
            Controls.Add(nameTrainAct);
            Controls.Add(Year);
            Controls.Add(label11);
            Controls.Add(town);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(nameCarriage);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnRoutesByDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(town_txt);
            Controls.Add(label4);
            Controls.Add(btnFindByTown);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(btnFindByName);
            Controls.Add(label2);
            Controls.Add(btnAddRoutes);
            Controls.Add(btnAddTrain);
            Controls.Add(label1);
            Controls.Add(btnRoutes);
            Controls.Add(btnTrain);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnTrain;
        private Button btnRoutes;
        private Label label1;
        private Button btnAddRoutes;
        private Button btnAddTrain;
        private Label label2;
        private Button btnFindByName;
        private Label label3;
        private TextBox name;
        private TextBox town_txt;
        private Label label4;
        private Button btnFindByTown;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnRoutesByDate;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox nameCarriage;
        private Label label9;
        private Label label10;
        private TextBox town;
        private Label label11;
        private TextBox Year;
        private TextBox nameTrainAct;
        private Label label12;
        private DateTimePicker dateTimePicker3;
        private Label label13;
    }
}