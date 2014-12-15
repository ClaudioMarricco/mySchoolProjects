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
    public partial class frmMainMenu : Form
    {
        string Role;

        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();

        public frmMainMenu(string incomingRole)
        {
            Role = incomingRole;
            InitializeComponent();
            pnlAdministrator.Show();
            pnlDoctors.Show();
            pnlGeneral.Show();
            pnlNurses.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            if (Role == "Doctor")
            {
                btnBilling.Enabled = false;
                btnDoctors.Enabled = false;
                btnWards.Enabled = false;
            }
            else if (Role == "Nurse")
            {
                btnBilling.Enabled = false;
                btnDoctors.Enabled = false;
                btnDischarge.Enabled = false;
                btnSurgicalReport.Enabled = false;

            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.Visible = true;
            Login.Activate();
            Login.Show();
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            frmNewPatient NewPatient = new frmNewPatient(Role);
            NewPatient.Visible = true;
            NewPatient.Activate();
            NewPatient.Show();
            this.Close();

        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            frmPatientList PatientList = new frmPatientList(Role);
            PatientList.Visible = true;
            PatientList.Activate();
            PatientList.Show();
            this.Close();
        }

        private void btnAdmissions_Click(object sender, EventArgs e)
        {
            btnQuit Admissions = new btnQuit(Role);
            Admissions.Visible = true;
            Admissions.Activate();
            Admissions.Show();
            this.Close();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            frmBilling Billing = new frmBilling(Role);
            Billing.Visible = true;
            Billing.Activate();
            Billing.Show();
            this.Close();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            frmDoctor Doctor = new frmDoctor(Role);
            Doctor.Visible = true;
            Doctor.Activate();
            Doctor.Show();
            this.Close();
        }

        private void btnSurgeryReport_Click(object sender, EventArgs e)
        {
            frmSurgicalReportViewer SurgicalReportViewer = new frmSurgicalReportViewer(Role);
            SurgicalReportViewer.Visible = true;
            SurgicalReportViewer.Activate();
            SurgicalReportViewer.Show();
            this.Close();
        }

        private void btnSurgicalReport_Click(object sender, EventArgs e)
        {
            frmSurgicalReport SurgicalReportViewer = new frmSurgicalReport(Role);
            SurgicalReportViewer.Visible = true;
            SurgicalReportViewer.Activate();
            SurgicalReportViewer.Show();
            this.Close();
        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            frmPatientList PatientList = new frmPatientList(Role);
            PatientList.Visible = true;
            PatientList.Activate();
            PatientList.Show();
            this.Close();
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            frmResources Resources = new frmResources(Role);
            Resources.Visible = true;
            Resources.Activate();
            Resources.Show();
            this.Close();
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            string HealthNumber = this.txtPatientID.Text;

            frmDischarge Discharge = new frmDischarge(this, HealthNumber);
            Discharge.ShowDialog();

        }

        private void btnWards_Click(object sender, EventArgs e)
        {
            frmWards Wards = new frmWards(Role);
            Wards.Visible = true;
            Wards.Activate();
            Wards.Show();
            this.Close();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
