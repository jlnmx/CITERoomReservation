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
        private TextBox textRoom = new TextBox();
        private ComboBox cmbCourse = new ComboBox();
        private ComboBox cmbSection = new ComboBox();
        private DateTimePicker dtpDate = new DateTimePicker();
        private DateTimePicker dtpStartTime = new DateTimePicker();
        private TextBox textName = new TextBox();
        private ComboBox cmbRole = new ComboBox();
        private TextBox textProf = new TextBox();

        public ReservationManagement()
        {
            InitializeComponent();
            InitializeControls();
        }
        private void InitializeControls()
        {
            textRoom = new TextBox();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            dtpDate = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            textName = new TextBox();
            cmbRole = new ComboBox();
            textProf = new TextBox();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
           
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
      
        }

    }
