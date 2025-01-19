using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CITERoomReservationForm
{
    public partial class InformationPage : Form
    {
        public InformationPage()
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
            ViewReservationPage viewReservationPage = new ViewReservationPage();
            viewReservationPage.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReservationPage reservationPage = new ReservationPage();
            reservationPage.Show();
            this.Hide();
        }
    }
}
