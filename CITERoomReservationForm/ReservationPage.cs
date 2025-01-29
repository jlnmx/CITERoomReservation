using CITERoomReserveLogic;
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
            string name = textName.Text;
            string course = txtCourse.Text;
            string section = txtSection.Text;
            string professor = textProf.Text;

            CITERoomReserve.AddInfo(name, course, section, professor);

            string room = txtReserveRoom.Text;
            string dateTime = txtReserveSched.Text;

            bool isReserved = CITERoomReserve.ReserveRoom(room, dateTime);

            if (isReserved)
            {
                MessageBox.Show("Room reserved successfully!");
            }
            else
            {
                MessageBox.Show("Failed to reserve room.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            List<string> rooms = CITERoomReserve.GetAvailableRooms();
            string message = string.Join(Environment.NewLine, rooms);
            MessageBox.Show(message, "Available Rooms");
        }

        private void btnViewSched_Click(object sender, EventArgs e)
        {
            List<string> schedules = CITERoomReserve.GetAvailableSchedules();
            string message = string.Join(Environment.NewLine, schedules);
            MessageBox.Show(message, "Available Schedules");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewReservations view = new ViewReservations();
            view.Show();
            this.Hide();
        }
    }
}

