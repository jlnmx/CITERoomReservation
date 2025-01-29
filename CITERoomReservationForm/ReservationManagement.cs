using CITERoomReserveLogic;
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
            InitializeControls();
            LoadReservations();
        }
        private void InitializeControls()
        {

        }
        private void LoadReservations()
        {
            listBoxManage.Items.Clear();
            List<string> reservations = CITERoomReserve.GetAllReservations();
            foreach (var reservation in reservations)
            {
                listBoxManage.Items.Add(reservation);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxManage.SelectedIndex != -1)
            {
                int reservationNumber = listBoxManage.SelectedIndex + 1;
                if (CITERoomReserve.DeleteReservation(reservationNumber))
                {
                    MessageBox.Show("Reservation deleted successfully!");
                    LoadReservations();
                }
                else
                {
                    MessageBox.Show("Deleting reservation failed. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to delete.");
            }
        }
        
        private void btnReturn_Click(object sender, EventArgs e)
        {
            EntryPage entryPage = new EntryPage();
            entryPage.Show();
            this.Hide();
        }

        private void listViewManage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservationPage reservationPage = new ReservationPage();
            reservationPage.Show();
            this.Hide();
        }

        private void listBoxManage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
