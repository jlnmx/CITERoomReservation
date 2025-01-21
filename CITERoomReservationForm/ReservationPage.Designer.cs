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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label8 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            comboBox6 = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            comboBox5 = new ComboBox();
            label11 = new Label();
            comboBox3 = new ComboBox();
            label10 = new Label();
            comboBox4 = new ComboBox();
            button6 = new Button();
            label15 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // textBox1
            // 
            textBox1.Location = new Point(79, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 23);
            textBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(79, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(84, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(250, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(74, 23);
            comboBox2.TabIndex = 4;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(79, 241);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 10;
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
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "hh:mm tt";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(79, 284);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(102, 23);
            dateTimePicker2.TabIndex = 13;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "hh:mm tt";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(212, 284);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(101, 23);
            dateTimePicker3.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(188, 287);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 15;
            label8.Text = "to";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dateTimePicker3);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(24, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 326);
            panel1.TabIndex = 16;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(311, 474);
            button3.Name = "button3";
            button3.Size = new Size(266, 26);
            button3.TabIndex = 19;
            button3.Text = "VIEW RESERVATIONS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column3, Column4, Column2, Column1 });
            dataGridView1.Location = new Point(432, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(467, 282);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column5
            // 
            Column5.HeaderText = "Room";
            Column5.Name = "Column5";
            Column5.Width = 75;
            // 
            // Column3
            // 
            Column3.HeaderText = "Course";
            Column3.Name = "Column3";
            Column3.Width = 75;
            // 
            // Column4
            // 
            Column4.HeaderText = "Section";
            Column4.Name = "Column4";
            Column4.Width = 70;
            // 
            // Column2
            // 
            Column2.HeaderText = "Date";
            Column2.Name = "Column2";
            Column2.Width = 110;
            // 
            // Column1
            // 
            Column1.HeaderText = "Time";
            Column1.Name = "Column1";
            Column1.Width = 110;
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
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(536, 383);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(108, 23);
            comboBox6.TabIndex = 4;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
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
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(536, 422);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(108, 23);
            comboBox5.TabIndex = 8;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
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
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(787, 381);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(108, 23);
            comboBox3.TabIndex = 10;
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
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(787, 419);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(108, 23);
            comboBox4.TabIndex = 12;
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
            Controls.Add(button3);
            Controls.Add(label15);
            Controls.Add(button6);
            Controls.Add(comboBox4);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox3);
            Controls.Add(label11);
            Controls.Add(button4);
            Controls.Add(comboBox5);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(comboBox6);
            Name = "ReservationPage";
            Text = "Reservation";
            Load += InformationPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label label8;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Label label9;
        private ComboBox comboBox6;
        private Label label13;
        private Label label12;
        private ComboBox comboBox5;
        private Label label11;
        private ComboBox comboBox3;
        private Label label10;
        private ComboBox comboBox4;
        private Button button6;
        private Label label15;
    }
}