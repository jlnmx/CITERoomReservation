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
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnReturn = new Button();
            dataGridViewManageReservations = new DataGridView();
            colRole = new DataGridViewComboBoxColumn();
            colRow = new DataGridViewTextBoxColumn();
            colCourse = new DataGridViewComboBoxColumn();
            colSection = new DataGridViewComboBoxColumn();
            colProfessor = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewComboBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManageReservations).BeginInit();
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
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(343, 427);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 24);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // dataGridViewManageReservations
            // 
            dataGridViewManageReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManageReservations.Columns.AddRange(new DataGridViewColumn[] { colRole, colRow, colCourse, colSection, colProfessor, colRoom, colDate, colTime });
            dataGridViewManageReservations.Location = new Point(29, 74);
            dataGridViewManageReservations.Name = "dataGridViewManageReservations";
            dataGridViewManageReservations.Size = new Size(812, 332);
            dataGridViewManageReservations.TabIndex = 8;
            dataGridViewManageReservations.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colRole
            // 
            colRole.HeaderText = "ROLE";
            colRole.Name = "colRole";
            colRole.Resizable = DataGridViewTriState.True;
            colRole.SortMode = DataGridViewColumnSortMode.Automatic;
            colRole.Width = 75;
            // 
            // colRow
            // 
            colRow.HeaderText = "NAME";
            colRow.Name = "colRow";
            colRow.Width = 150;
            // 
            // colCourse
            // 
            colCourse.HeaderText = "COURSE";
            colCourse.Name = "colCourse";
            colCourse.Resizable = DataGridViewTriState.True;
            colCourse.SortMode = DataGridViewColumnSortMode.Automatic;
            colCourse.Width = 70;
            // 
            // colSection
            // 
            colSection.HeaderText = "SECTION";
            colSection.Name = "colSection";
            colSection.Resizable = DataGridViewTriState.True;
            colSection.SortMode = DataGridViewColumnSortMode.Automatic;
            colSection.Width = 60;
            // 
            // colProfessor
            // 
            colProfessor.HeaderText = "PROFESSOR";
            colProfessor.Name = "colProfessor";
            colProfessor.Width = 150;
            // 
            // colRoom
            // 
            colRoom.HeaderText = "ROOM";
            colRoom.Name = "colRoom";
            colRoom.Resizable = DataGridViewTriState.True;
            colRoom.SortMode = DataGridViewColumnSortMode.Automatic;
            colRoom.Width = 65;
            // 
            // colDate
            // 
            colDate.HeaderText = "DATE";
            colDate.Name = "colDate";
            // 
            // colTime
            // 
            colTime.HeaderText = "TIME";
            colTime.Name = "colTime";
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
            // ReservationManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 492);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnReturn);
            Controls.Add(dataGridViewManageReservations);
            Controls.Add(label1);
            Name = "ReservationManagement";
            Text = "ReservationManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridViewManageReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnReturn;
        private DataGridView dataGridViewManageReservations;
        private DataGridViewComboBoxColumn colRole;
        private DataGridViewTextBoxColumn colRow;
        private DataGridViewComboBoxColumn colCourse;
        private DataGridViewComboBoxColumn colSection;
        private DataGridViewTextBoxColumn colProfessor;
        private DataGridViewComboBoxColumn colRoom;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private Label label1;
    }
}