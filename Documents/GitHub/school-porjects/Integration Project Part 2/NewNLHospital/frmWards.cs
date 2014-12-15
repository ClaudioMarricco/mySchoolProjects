using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Threading;
using System.IO;

namespace NewNLHospital
{
    public partial class frmWards : Form
    {
        string filePath = Directory.GetCurrentDirectory() + @"\CrystalReport1.rpt";
        string Role;
        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        DataTable thisDataTable = new DataTable();
        SqlCommand cmd = new SqlCommand();
        
        

        public frmWards(string incomingRole)
        {
            InitializeComponent();
            Role = incomingRole;
        }

        private void frmWards_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
               "SELECT Ward, HealthNumber, LastName, DoctorID FROM Patients", cn);

            thisDataAdapter.TableMappings.Add("Table", "Patients");

            thisDataAdapter.Fill(thisDataSet);
            thisDataAdapter.Fill(thisDataTable);

            ReportDocument rpt = new ReportDocument();
            rpt.Load(filePath);
            rpt.SetDataSource(thisDataSet);
            crystalReportViewer1.ReportSource = rpt;
            cn.Close();


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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmWards_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
