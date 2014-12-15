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
    public partial class frmNewPatient : Form
    {
        string Role;
        int totalOccupied;
        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();
        DataTable thisDataTable = new DataTable();

        public frmNewPatient(string incomingRole)
        {
            InitializeComponent();
            Role = incomingRole;
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPatients1.InsuranceCoverage' table. You can move, or remove it, as needed.
            this.insuranceCoverageTableAdapter.Fill(this.dsPatients1.InsuranceCoverage);
            // TODO: This line of code loads data into the 'dsPatients1.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.dsPatients1.Doctors);
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseScreen();
        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        private void sqlConnection1_InfoMessage_1(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
                "SELECT HealthNumber, DateOfBirth, LastName, FirstName, InsuranceNumber, DoctorID, Ward FROM Patients", cn);
            SqlDataAdapter thisDataAdapter1 = new SqlDataAdapter(
                "SELECT InsuranceNumberID, StreetAddress, City, Province, PostalCode, PhoneNumber, NextOfKin, Relation FROM PrivateInformation", cn);
            SqlDataAdapter thisDataAdapter2 = new SqlDataAdapter(
                "SELECT Occupied FROM Beds", cn);

            thisDataAdapter2.TableMappings.Add("Table", "Beds");
            thisDataAdapter2.Fill(thisDataSet);
            thisDataAdapter2.Fill(thisDataTable);

            foreach (DataRow row in thisDataSet.Tables[0].Rows)
            {
                if (row.ItemArray[0].ToString() == "True")
                {
                    totalOccupied += 1;
                }
            }

            if (totalOccupied <= thisDataSet.Tables[0].Rows.Count)
            {

                thisDataAdapter.Fill(thisDataSet, "Patients");
                thisDataAdapter1.Fill(thisDataSet, "PrivateInformation");
                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisDataAdapter);
                SqlCommandBuilder thisBuilder1 = new SqlCommandBuilder(thisDataAdapter1);

                try
                {
                    DataRow thisRow = thisDataSet.Tables["Patients"].NewRow();
                    thisRow["HealthNumber"] = this.txtHCNumber.Text;
                    thisRow["DateOfBirth"] = this.dateTimePicker1.Text;
                    thisRow["LastName"] = this.txtLastName.Text;
                    thisRow["FirstName"] = this.txtFirstName.Text;
                    thisRow["InsuranceNumber"] = this.cboInsurances.Text;
                    thisRow["DoctorID"] = this.cboDoctors.Text;
                    thisRow["Ward"] = this.comboWard.Text;

                    thisDataSet.Tables["Patients"].Rows.Add(thisRow);

                    //Call Update
                    thisDataAdapter.Update(thisDataSet, "Patients");
                    cn.Close();
                }

                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    DataRow thisRow1 = thisDataSet.Tables["PrivateInformation"].NewRow();
                    thisRow1["City"] = this.txtCity.Text;
                    thisRow1["StreetAddress"] = this.txtAddress.Text;
                    thisRow1["Province"] = this.cboProvince.Text;
                    thisRow1["PostalCode"] = this.txtPostalCode.Text;
                    thisRow1["PhoneNumber"] = this.txtPhoneN.Text;
                    thisRow1["NextOfKin"] = this.txtNoKin.Text;
                    thisRow1["Relation"] = this.txtRelation.Text;
                    thisRow1["InsuranceNumberID"] = this.cboInsurances.Text;

                    thisDataSet.Tables["PrivateInformation"].Rows.Add(thisRow1);

                    thisDataAdapter1.Update(thisDataSet, "PrivateInformation");
                    cn.Close();
                    MessageBox.Show("Patient Added");
                    CloseScreen();

                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Hospital is at maximum capacity!");
            }
        }

        private void sqlConnection1_InfoMessage_2(object sender, SqlInfoMessageEventArgs e)
        {

        }

        private void CloseScreen()
        {
            this.Close();
            frmMainMenu MainMenu = new frmMainMenu(Role);
            MainMenu.Visible = true;
            MainMenu.Activate();
            MainMenu.Show();
        }

        private void frmNewPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseScreen();
        }


    }
}
