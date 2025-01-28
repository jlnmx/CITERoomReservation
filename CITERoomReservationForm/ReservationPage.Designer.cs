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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationPage));
            label1 = new Label();
            textName = new TextBox();
            textProf = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button6 = new Button();
            button4 = new Button();
            label13 = new Label();
            txtCourse = new TextBox();
            txtSection = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label15 = new Label();
            label9 = new Label();
            btnViewRooms = new Button();
            btnViewSched = new Button();
            txtRoom = new TextBox();
            txtSched = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            label4.Location = new Point(197, 102);
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
            // panel1
            // 
            panel1.Controls.Add(txtSection);
            panel1.Controls.Add(txtCourse);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textProf);
            panel1.Controls.Add(textName);
            panel1.Location = new Point(24, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 326);
            panel1.TabIndex = 16;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(21, 284);
            button2.Name = "button2";
            button2.Size = new Size(83, 26);
            button2.TabIndex = 18;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(233, 284);
            button6.Name = "button6";
            button6.Size = new Size(93, 26);
            button6.TabIndex = 14;
            button6.Text = "CONFIRM";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(434, 386);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 6;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(18, 120);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(74, 23);
            txtCourse.TabIndex = 19;
            txtCourse.TextChanged += textBox1_TextChanged_1;
            // 
            // txtSection
            // 
            txtSection.Location = new Point(197, 120);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(65, 23);
            txtSection.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(15, 5);
            label6.Name = "label6";
            label6.Size = new Size(199, 21);
            label6.TabIndex = 12;
            label6.Text = "VIEW AVAILABLE ROOMS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(15, 178);
            label7.Name = "label7";
            label7.Size = new Size(202, 20);
            label7.TabIndex = 11;
            label7.Text = "VIEW RESERVED SCHEDULE";
            label7.Click += label7_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Maroon;
            label15.Location = new Point(15, 91);
            label15.Name = "label15";
            label15.Size = new Size(244, 21);
            label15.TabIndex = 3;
            label15.Text = "RESERVE AN AVAILABLE ROOM";
            label15.Click += label15_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(18, 257);
            label9.Name = "label9";
            label9.Size = new Size(164, 20);
            label9.TabIndex = 21;
            label9.Text = "RESERVE A SCHEDULE";
            label9.Click += label9_Click;
            // 
            // btnViewRooms
            // 
            btnViewRooms.Location = new Point(18, 43);
            btnViewRooms.Name = "btnViewRooms";
            btnViewRooms.Size = new Size(75, 23);
            btnViewRooms.TabIndex = 22;
            btnViewRooms.Text = "VIEW";
            btnViewRooms.UseVisualStyleBackColor = true;
            // 
            // btnViewSched
            // 
            btnViewSched.Location = new Point(18, 217);
            btnViewSched.Name = "btnViewSched";
            btnViewSched.Size = new Size(75, 23);
            btnViewSched.TabIndex = 23;
            btnViewSched.Text = "VIEW";
            btnViewSched.UseVisualStyleBackColor = true;
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(18, 123);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(148, 23);
            txtRoom.TabIndex = 24;
            // 
            // txtSched
            // 
            txtSched.Location = new Point(21, 286);
            txtSched.Name = "txtSched";
            txtSched.Size = new Size(151, 23);
            txtSched.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSched);
            panel2.Controls.Add(txtRoom);
            panel2.Controls.Add(btnViewSched);
            panel2.Controls.Add(btnViewRooms);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(380, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 326);
            panel2.TabIndex = 26;
            // 
            // ReservationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(702, 456);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label13);
            Name = "ReservationPage";
            Text = "Reservation";
            Load += InformationPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private TextBox textProf;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button button2;
        private Button button4;
        private Label label13;
        private Button button6;
        private TextBox txtSection;
        private TextBox txtCourse;
        private Label label6;
        private Label label7;
        private Label label15;
        private Label label9;
        private Button btnViewRooms;
        private Button btnViewSched;
        private TextBox txtRoom;
        private TextBox txtSched;
        private Panel panel2;
    }
}