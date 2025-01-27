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
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminRegister.Username = textUsername.Text;
            AdminRegister.Password = textPassword.Text;

           
            MessageBox.Show("Registration Successful", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AdminLogin login = new AdminLogin();
            login.Show();
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
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }
    }
}
