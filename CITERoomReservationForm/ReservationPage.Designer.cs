namespace CITERoomReservationForm
{
    partial class ReservationPage
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
            label1 = new Label();
            textName = new TextBox();
            textboxProf = new TextBox();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpDate = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            dtpStartTime = new DateTimePicker();
            panel1 = new Panel();
            button4 = new Button();
            dataGridViewReserved = new DataGridView();
            colRoom = new DataGridViewTextBoxColumn();
            colCourse = new DataGridViewTextBoxColumn();
            colSection = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            label9 = new Label();
            cmbGF = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            cmb2F = new ComboBox();
            label11 = new Label();
            cmb3F = new ComboBox();
            label10 = new Label();
            cmb4F = new ComboBox();
            button6 = new Button();
            label15 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReserved).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(326, 32);
            label1.TabIndex = 0;
            label1.Text = "FILL UP THE INFORMATION";
            // 
            // textName
            // 
            textName.Location = new Point(79, 42);
            textName.Name = "textName";
            textName.Size = new Size(290, 23);
            textName.TabIndex = 1;
            textName.TextChanged += textBox1_TextChanged;
            // 
            // textboxProf
            // 
            textboxProf.Location = new Point(79, 186);
            textboxProf.Name = "textboxProf";
            textboxProf.Size = new Size(290, 23);
            textboxProf.TabIndex = 2;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "BSCPE", "BSIE", "BSIT", "DCPET", "DIT" });
            cmbCourse.Location = new Point(79, 97);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(84, 23);
            cmbCourse.TabIndex = 3;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Items.AddRange(new object[] { "1-1", "1-2", "2-1", "3-1", "4-1", "LADDERIZED" });
            cmbSection.Location = new Point(250, 99);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(74, 23);
            cmbSection.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 21);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "NAME";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 102);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "COURSE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(188, 102);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 7;
            label4.Text = "SECTION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 158);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 8;
            label5.Text = "PROFESSOR'S NAME";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(79, 241);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(213, 23);
            dtpDate.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 247);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 11;
            label7.Text = "DATE";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 287);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 12;
            label6.Text = "TIME";
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(79, 284);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(102, 23);
            dtpStartTime.TabIndex = 13;
            dtpStartTime.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpStartTime);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dtpDate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbSection);
            panel1.Controls.Add(cmbCourse);
            panel1.Controls.Add(textboxProf);
            panel1.Controls.Add(textName);
            panel1.Location = new Point(24, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 326);
            panel1.TabIndex = 16;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(9, 3);
            button4.Name = "button4";
            button4.Size = new Size(63, 20);
            button4.TabIndex = 20;
            button4.Text = "RETURN";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridViewReserved
            // 
            dataGridViewReserved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReserved.Columns.AddRange(new DataGridViewColumn[] { colRoom, colCourse, colSection, colDate, colTime });
            dataGridViewReserved.Location = new Point(432, 61);
            dataGridViewReserved.Name = "dataGridViewReserved";
            dataGridViewReserved.Size = new Size(467, 282);
            dataGridViewReserved.TabIndex = 22;
            dataGridViewReserved.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colRoom
            // 
            colRoom.HeaderText = "ROOM";
            colRoom.Name = "colRoom";
            colRoom.Width = 75;
            // 
            // colCourse
            // 
            colCourse.HeaderText = "COURSE";
            colCourse.Name = "colCourse";
            colCourse.Width = 75;
            // 
            // colSection
            // 
            colSection.HeaderText = "SECTION";
            colSection.Name = "colSection";
            colSection.Width = 70;
            // 
            // colDate
            // 
            colDate.HeaderText = "DATE";
            colDate.Name = "colDate";
            colDate.Width = 110;
            // 
            // colTime
            // 
            colTime.HeaderText = "TIME";
            colTime.Name = "colTime";
            colTime.Width = 110;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(432, 26);
            label9.Name = "label9";
            label9.Size = new Size(227, 32);
            label9.TabIndex = 23;
            label9.Text = "RESERVED ROOMS";
            // 
            // cmbGF
            // 
            cmbGF.AutoCompleteCustomSource.AddRange(new string[] { "101", "102", "103", "104", "105" });
            cmbGF.FormattingEnabled = true;
            cmbGF.Location = new Point(536, 383);
            cmbGF.Name = "cmbGF";
            cmbGF.Size = new Size(108, 23);
            cmbGF.TabIndex = 4;
            cmbGF.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(434, 386);
            label13.Name = "label13";
            label13.Size = new Size(96, 15);
            label13.TabIndex = 6;
            label13.Text = "GROUND FLOOR";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(436, 425);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 7;
            label12.Text = "2ND FLOOR";
            // 
            // cmb2F
            // 
            cmb2F.AutoCompleteCustomSource.AddRange(new string[] { "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212" });
            cmb2F.FormattingEnabled = true;
            cmb2F.Location = new Point(536, 422);
            cmb2F.Name = "cmb2F";
            cmb2F.Size = new Size(108, 23);
            cmb2F.TabIndex = 8;
            cmb2F.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(687, 384);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 9;
            label11.Text = "3RD FLOOR";
            // 
            // cmb3F
            // 
            cmb3F.AutoCompleteCustomSource.AddRange(new string[] { "301", "302", "303", "304", "305", "306", "307", "308", "309", "310" });
            cmb3F.FormattingEnabled = true;
            cmb3F.Location = new Point(787, 381);
            cmb3F.Name = "cmb3F";
            cmb3F.Size = new Size(108, 23);
            cmb3F.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(688, 425);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 11;
            label10.Text = "4TH FLOOR";
            // 
            // cmb4F
            // 
            cmb4F.AutoCompleteCustomSource.AddRange(new string[] { "401", "402", "403", "404", "405", "406", "407", "408" });
            cmb4F.FormattingEnabled = true;
            cmb4F.Location = new Point(787, 419);
            cmb4F.Name = "cmb4F";
            cmb4F.Size = new Size(108, 23);
            cmb4F.TabIndex = 12;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(806, 454);
            button6.Name = "button6";
            button6.Size = new Size(93, 33);
            button6.TabIndex = 14;
            button6.Text = "CONFIRM";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Maroon;
            label15.Location = new Point(432, 348);
            label15.Name = "label15";
            label15.Size = new Size(244, 21);
            label15.TabIndex = 3;
            label15.Text = "RESERVE AN AVAILABLE ROOM";
            label15.Click += label15_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(40, 414);
            button2.Name = "button2";
            button2.Size = new Size(83, 26);
            button2.TabIndex = 18;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ReservationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 524);
            Controls.Add(button2);
            Controls.Add(label15);
            Controls.Add(button6);
            Controls.Add(cmb4F);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(dataGridViewReserved);
            Controls.Add(cmb3F);
            Controls.Add(label11);
            Controls.Add(button4);
            Controls.Add(cmb2F);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(cmbGF);
            Name = "ReservationPage";
            Text = "Reservation";
            Load += InformationPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReserved).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private TextBox textboxProf;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpDate;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpStartTime;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Panel panel2;
        private DataGridView dataGridViewReserved;
        private Label label9;
        private ComboBox cmbGF;
        private Label label13;
        private Label label12;
        private ComboBox cmb2F;
        private Label label11;
        private ComboBox cmb3F;
        private Label label10;
        private ComboBox cmb4F;
        private Button button6;
        private Label label15;
        private DataGridViewTextBoxColumn colRoom;
        private DataGridViewTextBoxColumn colCourse;
        private DataGridViewTextBoxColumn colSection;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
    }
}