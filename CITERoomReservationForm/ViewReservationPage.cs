﻿using System;
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
    public partial class ViewReservationPage : Form
    {

        public ViewReservationPage()

        {

            InitializeComponent();

        }



        private void Label1_Click(object sender, EventArgs e)

        {

            // Add your event handler code here

        }

        private void button3_Click(object sender, EventArgs e)
        {

/* Unmerged change from project 'CITERoomReservationForm'
Before:
            InformationPage informationPage = new InformationPage();
            informationPage.Show();
After:
            ReservationPage informationPage = new ReservationPage();
            informationPage.Show();
*/
            ReservationPage informationPage = new InformationPage();
            informationPage.Show();
            this.Hide();
        }
    }
}
