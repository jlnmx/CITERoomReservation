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
            textProf = new TextBox();
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
            cmbRole = new ComboBox();
            label8 = new Label();
            button4 = new Button();
            label9 = new Label();
            label13 = new Label();
            button6 = new Button();
            label15 = new Label();
            button2 = new Button();
            textRoom = new TextBox();
            listView1 = new ListView();
            colRoom = new ColumnHeader();
            colCourse = new ColumnHeader();
            colSection = new ColumnHeader();
            colDate = new ColumnHeader();
            colTime = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            panel1.SuspendLayout();
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
            textName.Location = new Point(21, 39);
            textName.Name = "textName";
            textName.Size = new Size(198, 23);
            textName.TabIndex = 1;
            textName.TextChanged += textBox1_TextChanged;
            // 
            // textProf
            // 
            textProf.Location = new Point(16, 189);
            textProf.Name = "textProf";
            textProf.Size = new Size(203, 23);
            textProf.TabIndex = 2;
            textProf.TextChanged += textProf_TextChanged;
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
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(label8);
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
            panel1.Controls.Add(textProf);
            panel1.Controls.Add(textName);
            panel1.Location = new Point(24, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 326);
            panel1.TabIndex = 16;
            // 
            // cmbRole
            // 
            cmbRole.AutoCompleteCustomSource.AddRange(new string[] { "Student", "Faculty" });
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Student", "Faculty" });
            cmbRole.Location = new Point(252, 189);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(74, 23);
            cmbRole.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(250, 158);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 14;
            label8.Text = "ROLE";
            label8.Click += label8_Click;
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(434, 386);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 6;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(806, 398);
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
            label15.Location = new Point(432, 366);
            label15.Name = "label15";
            label15.Size = new Size(244, 21);
            label15.TabIndex = 3;
            label15.Text = "RESERVE AN AVAILABLE ROOM";
            label15.Click += label15_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(24, 405);
            button2.Name = "button2";
            button2.Size = new Size(83, 26);
            button2.TabIndex = 18;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textRoom
            // 
            textRoom.Location = new Point(434, 404);
            textRoom.Name = "textRoom";
            textRoom.Size = new Size(157, 23);
            textRoom.TabIndex = 24;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colRoom, colCourse, colSection, colDate, colTime, columnHeader1 });
            listView1.Location = new Point(442, 68);
            listView1.Name = "listView1";
            listView1.Size = new Size(457, 275);
            listView1.TabIndex = 25;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ReservationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 456);
            Controls.Add(listView1);
            Controls.Add(textRoom);
            Controls.Add(button2);
            Controls.Add(label15);
            Controls.Add(button6);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label13);
            Name = "ReservationPage";
            Text = "Reservation";
            Load += InformationPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private TextBox textProf;
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
        private Label label9;
        private Label label13;
        private Button button6;
        private Label label15;
        private TextBox textRoom;
        private Label label8;
        private ComboBox cmbRole;
        private ListView listView1;
        private ColumnHeader colRoom;
        private ColumnHeader colCourse;
        private ColumnHeader colSection;
        private ColumnHeader colDate;
        private ColumnHeader colTime;
        private ColumnHeader columnHeader1;
    }
}