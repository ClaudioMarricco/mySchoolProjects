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
    public partial class btnQuit : Form
    {
        string Role;
        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();

        public btnQuit(string incomingRole)
        {
            InitializeComponent();
            Role = incomingRole;   
        }

        private void frmAdmission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPatients.AdmissionRecord' table. You can move, or remove it, as needed.
            this.admissionRecordTableAdapter.Fill(this.dSPatients.AdmissionRecord);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvAdmission.CurrentCell.RowIndex;
            int columnindex = 0; //dgvAdmission.CurrentCell.ColumnIndex;
            string thisAdminID = dgvAdmission.Rows[rowindex].Cells[columnindex].Value.ToString();

            frmAdmissionDetail AdmissionDetail = new frmAdmissionDetail(this, thisAdminID);
            AdmissionDetail.ShowDialog();
        }
        
        private void CloseScreen()
        {
            this.Close();
            frmMainMenu MainMenu = new frmMainMenu(Role);
            MainMenu.Visible = true;
            MainMenu.Activate();
            MainMenu.Show();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            
                cn.Open();

                Random rnd = new Random();
                int AdmisID = rnd.Next(1000, 9999);
                SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
                    "SELECT AdmissionID, PatientID, BedNumber, SurgeryScheduled, AdmissionDate, SurgeryDate, DischargeDate, TV, Phone FROM AdmissionRecord", cn);
                SqlDataAdapter thisDataAdapter1 = new SqlDataAdapter(
                    "SELECT BedNumber, Occupied FROM Beds", cn);

                thisDataAdapter.Fill(thisDataSet, "AdmissionRecord");
                thisDataAdapter1.Fill(thisDataSet, "Beds");
                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisDataAdapter);
                SqlCommandBuilder thisBuilder1 = new SqlCommandBuilder(thisDataAdapter1);


                try
                {
                    DataRow thisRow = thisDataSet.Tables["AdmissionRecord"].NewRow();
                    thisRow["AdmissionID"] = AdmisID.ToString();
                    thisRow["PatientID"] = this.txtPatientID.Text;
                    thisRow["BedNumber"] = this.cboBed.Text;
                    thisRow["AdmissionDate"] = this.dateTimePicker3.Text;
                    thisRow["SurgeryDate"] = this.dateTimePicker2.Text;
                    thisRow["DischargeDate"] = this.dateTimePicker1.Text;

                    bool i = false;
                    if (chkSurScheduled.Checked)
                    {
                        i = true;
                    }

                    thisRow["SurgeryScheduled"] = i.ToString();

                    bool x = false;
                    if (chkTV.Checked)
                    {
                        x = true;
                    }

                    thisRow["TV"] = x.ToString();

                    bool y = false;
                    if (chkPhone.Checked)
                    {
                        y = true;
                    }

                    thisRow["Phone"] = y.ToString();

                    thisDataSet.Tables["AdmissionRecord"].Rows.Add(thisRow);


                    //Call Update
                    thisDataAdapter.Update(thisDataSet, "AdmissionRecord");
                    MessageBox.Show("Patient Admission Entered" + "\r\nAdmission ID: " +AdmisID);
                    cn.Close();
                    CloseScreen();
                }


                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }

                cn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("UPDATE Beds SET Occupied=@Occupied WHERE BedNumber=@BedNumber", cn))
                    try
                    {
                        cmd.Parameters.AddWithValue("@BedNumber", cboBed.Text);
                        string i = "True";

                        cmd.Parameters.AddWithValue("@Occupied", i);

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

        private void button1_Click(object sender, EventArgs e)
        {
            CloseScreen();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }



    }
}
