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
    public partial class frmSurgicalReport : Form
    {
        string Role;
        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();

        public frmSurgicalReport(string incomingRole)
        {
            InitializeComponent();
            Role = incomingRole;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
                "SELECT HealthNumber, LastName, FirstName, LeadSurgeonID, ProcedureType, DatePerformed, Druation FROM SurgicalReprot", cn);
            
            thisDataAdapter.Fill(thisDataSet, "SurgicalReport");
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisDataAdapter);
            try
            {
                DataRow thisRow = thisDataSet.Tables["SurgicalReport"].NewRow();
                thisRow["HealthNumber"] = this.txtHealthCareNumber.Text;
                thisRow["LastName"] = this.txtLastName.Text;
                thisRow["FirstName"] = this.txtFirstName.Text;
                thisRow["LeadSurgeonID"] = this.txtLeadSurgeon.Text;
                thisRow["ProcedureType"] = this.txtProcedure.Text;
                thisRow["DatePerformed"] = this.cboDate.Text;
                thisRow["Duration"] = this.txtDuration.Text;

                thisDataSet.Tables["SurgicalReport"].Rows.Add(thisRow);

                //Call Update
                thisDataAdapter.Update(thisDataSet, "SurgicalReport");
                MessageBox.Show("Report Added");
                cn.Close();
            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseScreen()
        {
            this.Close();
            frmMainMenu MainMenu = new frmMainMenu(Role);
            MainMenu.Visible = true;
            MainMenu.Activate();
            MainMenu.Show();
        }
         
        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseScreen();
        }

        private void frmSurgicalReport_Load(object sender, EventArgs e)
        {

        }

        private void frmSurgicalReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseScreen();
        }
    }
}
