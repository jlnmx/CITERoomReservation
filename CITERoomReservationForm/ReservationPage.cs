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
        public List<Reservation> Reservations { get; private set; } = new List<Reservation>();

        public ReservationPage()
        {
            InitializeComponent();
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
            try
            {
                string room = textRoom.Text;
                string course = cmbCourse.SelectedItem?.ToString() ?? string.Empty;
                string section = cmbSection.SelectedItem?.ToString() ?? string.Empty;
                DateTime date = dtpDate.Value;
                string time = dtpStartTime.Value.ToString("HH:mm");
                string name = textName.Text;
                string role = cmbRole.SelectedItem?.ToString() ?? string.Empty;
                string professor = textProf.Text;

                var reservation = new Reservation
                {
                    Room = room,
                    Course = course,
                    Section = section,
                    Date = date,
                    Time = time,
                    Name = name,
                    Role = role,
                    Professor = professor
                };

                Reservations.Add(reservation);

                var reservationManagement = Application.OpenForms.OfType<ReservationManagement>().FirstOrDefault();

                MessageBox.Show("Reservation Confirmed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Reservation: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textRoom.Clear();
            cmbCourse.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
            dtpStartTime.Value = DateTime.Now;
            textName.Clear();
            cmbRole.SelectedIndex = -1;
            textProf.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textProf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
