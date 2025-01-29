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
using CITERoomReserveLogic;

namespace CITERoomReservationForm
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminMode_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textUsername.Text;
            string pass = textPassword.Text;

            if (CITERoomReserve.AdminLogin(user, pass))
            {
                MessageBox.Show("Login successful!");
                ReservationManagement manage = new ReservationManagement();
                manage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            AdminRegistration register = new AdminRegistration();
            register.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntryPage menu = new EntryPage();
            menu.Show();
            this.Hide();
        }
    }
}
