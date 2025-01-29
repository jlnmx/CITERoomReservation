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

namespace CITERoomReservationForm
{
    public partial class ViewReservations : Form
    {
        public ViewReservations()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            listBoxReservations.Items.Clear();
            List<string> reservations = CITERoomReserve.GetAllReservations();
            foreach (var reservation in reservations)
            {
                listBoxReservations.Items.Add(reservation);
            }

        }

        private void listBoxReservations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservationPage reservePage = new ReservationPage();
            reservePage.Show();
            this.Hide();
                
        }
    }
}
