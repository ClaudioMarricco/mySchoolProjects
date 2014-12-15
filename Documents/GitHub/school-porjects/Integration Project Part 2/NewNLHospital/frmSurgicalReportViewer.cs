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
    public partial class frmSurgicalReportViewer : Form
    {
        string Role;
        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();

        public frmSurgicalReportViewer(string incomingRole)
        {
            InitializeComponent();
            Role = incomingRole;
        }

        private void frmSergicalReport_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            // TODO: This line of code loads data into the 'dSPatients.SurgicalReport' table. You can move, or remove it, as needed.
            this.SurgicalReportTableAdapter.Fill(this.dSPatients.SurgicalReport);

        }

        private void lstSurgical_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BindingContext[this.dSPatients, "SurgicalReport"].Position =
                this.lstSurgical.SelectedIndex;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
               "SELECT Duration, ProcedureType, HealthNumber FROM SurgicalReport", cn);

            string thisHealthNumber = lstSurgical.GetItemText(lstSurgical.SelectedItem);


            using (SqlCommand cmd =
                new SqlCommand("UPDATE SurgicalReport SET Duration=@Duration, ProcedureType=@ProcedureType WHERE HealthNumber=@HealthNumber", cn))
                try
                {
                    cmd.Parameters.AddWithValue("@HealthNumber", thisHealthNumber);
                    cmd.Parameters.AddWithValue("@Duration", txtDuration.Text);
                    cmd.Parameters.AddWithValue("@ProcedureType", txtProcedure.Text);

                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Update Complete");
                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine(ex.Message);
                }
        }

        private void frmSurgicalReportViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseScreen();
        }
    }
}
