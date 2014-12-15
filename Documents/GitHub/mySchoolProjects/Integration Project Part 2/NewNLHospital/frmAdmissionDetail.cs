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
    public partial class frmAdmissionDetail : Form
    {
        btnQuit OriginalForm;

        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();

        private void frmAdmissionDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPatients.AdmissionRecord' table. You can move, or remove it, as needed.
            this.admissionRecordTableAdapter.Fill(this.dSPatients.AdmissionRecord);
            cmd.Connection = cn;

        }

        public frmAdmissionDetail(btnQuit IncomingForm, string IncomingString)
        {
            OriginalForm = IncomingForm;

            InitializeComponent();
            this.txtAdmissionID.Text = IncomingString.ToString();

            cn.Open();
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
               "SELECT AdmissionID, PatientID, BedNumber, SurgeryScheduled, AdmissionDate, SurgeryDate, DischargeDate FROM AdmissionRecord", cn);

            using (SqlCommand cmd =
                new SqlCommand("SELECT AdmissionID, PatientID, BedNumber, SurgeryScheduled, AdmissionDate, SurgeryDate, DischargeDate FROM AdmissionRecord WHERE AdmissionID = " + txtAdmissionID.Text, cn))

                try
                {
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        txtAdmissionID.Text = sdr["AdmissionID"].ToString();
                        txtPatientID.Text = sdr["PatientID"].ToString();
                        dateTimePicker3.Text = sdr["AdmissionDate"].ToString();
                        dateTimePicker2.Text = sdr["SurgeryDate"].ToString();
                        dateTimePicker1.Text = sdr["DischargeDate"].ToString();
                        cboBed.Text = sdr["BedNumber"].ToString();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
               "SELECT AdmissionID, PatientID, BedNumber, SurgeryScheduled, AdmissionDate, SurgeryDate, DischargeDate FROM AdmissionRecord", cn);

            string thisAdmissionID = this.txtAdmissionID.Text;


            using (SqlCommand cmd =
                new SqlCommand("UPDATE AdmissionRecord SET PatientID=@PatientID, SurgeryScheduled=@SurgeryScheduled, BedNumber=@BedNumber, AdmissionDate=@AdmissionDate, SurgeryDate=@SurgeryDate, DischargeDate=@DischargeDate WHERE AdmissionID=@AdmissionID", cn))
                try
                {
                    cmd.Parameters.AddWithValue("@AdmissionID", thisAdmissionID);
                    cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);
                    cmd.Parameters.AddWithValue("@BedNumber", cboBed.Text);
                    cmd.Parameters.AddWithValue("@SurgeryDate", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@AdmissionDate", dateTimePicker3.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@DischargeDate", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                    bool i = false ;
                     if (chkSurScheduled.Checked)
                        {
                            i = true;
                        }

                    cmd.Parameters.AddWithValue("@SurgeryScheduled", i.ToString());
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

        private void frmAdmissionDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
