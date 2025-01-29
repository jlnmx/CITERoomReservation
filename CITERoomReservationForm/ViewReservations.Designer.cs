namespace CITERoomReservationForm
{
    partial class ViewReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReservations));
            label1 = new Label();
            panel1 = new Panel();
            listBoxReservations = new ListBox();
            btnViewReservations = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(139, 27);
            label1.Name = "label1";
            label1.Size = new Size(201, 25);
            label1.TabIndex = 0;
            label1.Text = "VIEW RESERVATIONS";
            // 
            // panel1
            // 
            panel1.Controls.Add(listBoxReservations);
            panel1.Controls.Add(btnViewReservations);
            panel1.Location = new Point(30, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 320);
            panel1.TabIndex = 1;
            // 
            // listBoxReservations
            // 
            listBoxReservations.FormattingEnabled = true;
            listBoxReservations.ItemHeight = 15;
            listBoxReservations.Location = new Point(38, 32);
            listBoxReservations.Name = "listBoxReservations";
            listBoxReservations.Size = new Size(358, 169);
            listBoxReservations.TabIndex = 1;
            listBoxReservations.SelectedIndexChanged += listBoxReservations_SelectedIndexChanged;
            // 
            // btnViewReservations
            // 
            btnViewReservations.BackColor = Color.Maroon;
            btnViewReservations.FlatStyle = FlatStyle.Popup;
            btnViewReservations.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewReservations.ForeColor = SystemColors.ButtonHighlight;
            btnViewReservations.Location = new Point(135, 245);
            btnViewReservations.Name = "btnViewReservations";
            btnViewReservations.Size = new Size(147, 54);
            btnViewReservations.TabIndex = 0;
            btnViewReservations.Text = "VIEW";
            btnViewReservations.UseVisualStyleBackColor = false;
            btnViewReservations.Click += btnViewReservations_Click;
            // 
            // ViewReservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(486, 430);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ViewReservations";
            Text = "ViewReservations";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;

/* Unmerged change from project 'CITERoomReservation'
Before:
        private Button button1;
    }
After:
        private Button btnViewReservations;
    }
*/
        private Button btnViewReservations;
        private ListBox listBoxReservations;
    }
}