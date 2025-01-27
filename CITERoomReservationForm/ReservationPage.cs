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
    public partial class ReservationPage : Form
    {
        public string Role { get; set; }

        public ReservationPage()
        {
            InitializeComponent();
        }

        public ReservationPage(string role) : this()
        {
            Role = role;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void InformationPage_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReservationManagement viewReservationPage = new ReservationManagement();
            viewReservationPage.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EntryPage entryPage = new EntryPage();
            entryPage.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string room = cmbGF.SelectedItem?.ToString() ?? cmb2F.SelectedItem?.ToString() ?? cmb3F.SelectedItem?.ToString() ?? cmb4F.SelectedItem?.ToString();
            string course = cmbCourse.SelectedItem.ToString();
            string section = cmbSection.SelectedItem.ToString();
            DateTime date = dtpDate.Value;
            string time = dtpStartTime.Value.ToString("HH:mm");
            string name = textName.Text;
            string professor = textboxProf.Text;

            dataGridViewReserved.Rows.Add(room, course, section, date.ToShortDateString(), time);

            ReservationManagement reservationManagement = new ReservationManagement();
            reservationManagement.AddReservation(room, course, section, date, time, name, Role, professor);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
