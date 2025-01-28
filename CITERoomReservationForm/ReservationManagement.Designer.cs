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
            btnEdit = new Button();
            btnReturn = new Button();
            reservationBindingSource = new BindingSource(components);
            label1 = new Label();
            listViewManage = new ListView();
            colRole = new ColumnHeader();
            colName = new ColumnHeader();
            colCourse = new ColumnHeader();
            colSection = new ColumnHeader();
            colRoom = new ColumnHeader();
            colProf = new ColumnHeader();
            colDate = new ColumnHeader();
            colTime = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(505, 427);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(424, 427);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 24);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(29, 427);
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
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(265, 30);
            label1.TabIndex = 7;
            label1.Text = "MANAGE RESERVATIONS";
            label1.Click += label1_Click;
            // 
            // listViewManage
            // 
            listViewManage.Columns.AddRange(new ColumnHeader[] { colRole, colName, colCourse, colSection, colRoom, colProf, colDate, colTime });
            listViewManage.Location = new Point(40, 81);
            listViewManage.Name = "listViewManage";
            listViewManage.Size = new Size(801, 327);
            listViewManage.TabIndex = 13;
            listViewManage.UseCompatibleStateImageBehavior = false;
            listViewManage.View = View.List;
            listViewManage.SelectedIndexChanged += listViewManage_SelectedIndexChanged;
            // 
            // ReservationManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 492);
            Controls.Add(listViewManage);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
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
        private Button btnEdit;
        private Button btnReturn;
        private Label label1;
        private BindingSource reservationBindingSource;
        private ListView listViewManage;
        private ColumnHeader colRole;
        private ColumnHeader colName;
        private ColumnHeader colCourse;
        private ColumnHeader colSection;
        private ColumnHeader colRoom;
        private ColumnHeader colProf;
        private ColumnHeader colDate;
        private ColumnHeader colTime;
    }
}