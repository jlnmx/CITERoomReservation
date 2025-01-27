using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CITERoomReservationForm
{
    public partial class ReservationManagement : Form
    {
        public ReservationManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void AddReservation(string room, string course, string section, DateTime date, string time, string name, string role, string professor)
        {
            dataGridViewManageReservations.Rows.Add(room, course, section, date.ToShortDateString(), time, name, role, professor);
            SyncReservations();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string room = cmbRoom.SelectedItem?.ToString();
            string course = cmbCourse.SelectedItem.ToString();
            string section = cmbSection.SelectedItem.ToString();
            DateTime date = dtpDate.Value;
            string time = dtpStartTime.Value.ToString("HH:mm");
            string name = txtName.Text;
            string role = txtRole.Text;
            string professor = txtProfessor.Text;

            AddReservation(room, course, section, date, time, name, role, professor);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewManageReservations.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewManageReservations.SelectedRows[0];
                selectedRow.Cells["Room"].Value = cmbRoom.SelectedItem?.ToString();
                selectedRow.Cells["Course"].Value = cmbCourse.SelectedItem.ToString();
                selectedRow.Cells["Section"].Value = cmbSection.SelectedItem.ToString();
                selectedRow.Cells["Date"].Value = dtpDate.Value.ToShortDateString();
                selectedRow.Cells["Time"].Value = dtpStartTime.Value.ToString("HH:mm");
                selectedRow.Cells["Name"].Value = txtName.Text;
                selectedRow.Cells["Role"].Value = txtRole.Text;
                selectedRow.Cells["Professor"].Value = txtProfessor.Text;
                SyncReservations();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewManageReservations.SelectedRows.Count > 0)
            {
                dataGridViewManageReservations.Rows.RemoveAt(dataGridViewManageReservations.SelectedRows[0].Index);
                SyncReservations();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            EntryPage entryPage = new EntryPage();
            entryPage.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SyncReservations()
        {
            ReservationPage reservationPage = new ReservationPage(txtRole.Text);
            reservationPage.dataGridViewReserved.Rows.Clear();

            foreach (DataGridViewRow row in dataGridViewManageReservations.Rows)
            {
                reservationPage.dataGridViewReserved.Rows.Add(
                    row.Cells["Room"].Value,
                    row.Cells["Course"].Value,
                    row.Cells["Section"].Value,
                    row.Cells["Date"].Value,
                    row.Cells["Time"].Value
                );
            }
        }
        private ComboBox cmbRoom;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpStartTime;
        private TextBox txtName;
        private TextBox txtRole;
        private TextBox txtProfessor;
    }
}