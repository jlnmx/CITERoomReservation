using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CITERoomReservationForm;
using CITERoomReserveLogic;


namespace CITERoomReservationForm
{
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            CITERoomReserve.AdminRegister(username, password);
            MessageBox.Show("Successfully registered account: " + username);

            ReservationManagement manage = new ReservationManagement();
            manage.Show();
            this.Hide();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            EntryPage menu = new EntryPage();
            menu.Show();
            this.Hide();
        }
    }
}