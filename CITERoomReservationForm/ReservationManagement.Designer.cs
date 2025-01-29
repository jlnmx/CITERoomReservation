namespace CITERoomReservationForm
{
    partial class ReservationManagement
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
            components = new System.ComponentModel.Container();
            btnDelete = new Button();
            btnReturn = new Button();
            reservationBindingSource = new BindingSource(components);
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(473, 356);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 24);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(29, 356);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(89, 24);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "RETURN";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(265, 30);
            label1.TabIndex = 7;
            label1.Text = "MANAGE RESERVATIONS";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(368, 356);
            button1.Name = "button1";
            button1.Size = new Size(65, 24);
            button1.TabIndex = 14;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(29, 72);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(509, 259);
            listBox1.TabIndex = 15;
            // 
            // ReservationManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 414);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(btnReturn);
            Controls.Add(label1);
            Name = "ReservationManagement";
            Text = "ReservationManagement";
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnReturn;
        private Label label1;
        private BindingSource reservationBindingSource;
        private Button button1;
        private ListBox listBox1;
    }
}