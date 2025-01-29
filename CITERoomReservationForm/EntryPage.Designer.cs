namespace CITERoomReservationForm
{
    partial class EntryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryPage));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnStart = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(226, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 105);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(65, 164);
            label1.Name = "label1";
            label1.Size = new Size(424, 54);
            label1.TabIndex = 1;
            label1.Text = "PUPBC CITE CAMPUS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(84, 218);
            label2.Name = "label2";
            label2.Size = new Size(396, 37);
            label2.TabIndex = 2;
            label2.Text = "ROOM RESERVATION SYSTEM";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Maroon;
            btnStart.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = SystemColors.ButtonHighlight;
            btnStart.Location = new Point(226, 337);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(108, 41);
            btnStart.TabIndex = 4;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(71, 24);
            button3.TabIndex = 7;
            button3.Text = "ADMIN MODE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EntryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(553, 473);
            Controls.Add(button3);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "EntryPage";
            Text = "PUPBC CITE ROOM RESERVATION SYSTEM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnStart;
        private Button button3;
    }
}
