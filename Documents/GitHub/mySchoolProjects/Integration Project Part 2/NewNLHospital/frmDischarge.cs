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
    public partial class frmDischarge : Form
    {
        frmMainMenu OriginalForm;

        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();

        public frmDischarge(frmMainMenu IncomingForm, string IncomingString)
        {
            OriginalForm = IncomingForm;
        
            InitializeComponent();

            this.txtHealthNumber.Text = IncomingString.ToString();

            cn.Open();
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
               "SELECT HealthNumber, Ward, FirstName, LastName FROM Patients", cn);

            using (SqlCommand cmd =
                new SqlCommand("SELECT HealthNumber, Ward, FirstName, Lastname FROM Patients WHERE HealthNumber = " + txtHealthNumber.Text, cn))

                try
                {
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        txtHealthNumber.Text = sdr["HealthNumber"].ToString();
                        txtFirstName.Text = sdr["FirstName"].ToString();
                        txtLastName.Text = sdr["LastName"].ToString();
                        txtWard.Text = sdr["Ward"].ToString();
                    }
                    sdr.Close();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine(ex.Message);
                }

        }

        private void frmDischarge_Load(object sender, EventArgs e)
        {

        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            cn.Open();
            string patientDischarge = "Discharged";
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
               "SELECT HealthNumber, Ward FROM Patients", cn);

            using (SqlCommand cmd =
                new SqlCommand("UPDATE Patients SET Ward=@Ward WHERE HealthNumber=@HealthNumber", cn))
                try
                {
                    cmd.Parameters.AddWithValue("@HealthNumber", txtHealthNumber.Text);
                    cmd.Parameters.AddWithValue("@Ward", patientDischarge.ToString());

                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Patient discharged");
                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine(ex.Message);
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDischarge_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

    }
}
