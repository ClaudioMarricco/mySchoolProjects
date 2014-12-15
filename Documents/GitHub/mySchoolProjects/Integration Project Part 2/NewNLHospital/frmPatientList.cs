using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewNLHospital
{
    public partial class frmPatientList : Form
    {
        string Role;
        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();

        public frmPatientList(string incomingRole)
        {
            InitializeComponent();
            Role = incomingRole;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lstPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BindingContext[this.dSPatients, "Patients"].Position =
                this.lstPatient.SelectedIndex;
        }

        private void frmPatientList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPatients.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.dSPatients.Patients);
            // TODO: This line of code loads data into the 'dSPatients.AdmissionRecord' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.dSPatients.Patients);
            // TODO: This line of code loads data into the 'dsPatients1.Patients' table. You can move, or remove it, as needed.
            //this.patientsTableAdapter.Fill(this.dSPatients.Patients);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseScreen();
        }

        private void CloseScreen()
        {
            this.Close();
            frmMainMenu MainMenu = new frmMainMenu(Role);
            MainMenu.Visible = true;
            MainMenu.Activate();
            MainMenu.Show();
        }

        private void frmPatientList_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseScreen();
        }
    }
}
