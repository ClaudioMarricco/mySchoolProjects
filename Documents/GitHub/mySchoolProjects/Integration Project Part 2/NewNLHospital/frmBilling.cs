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
    public partial class frmBilling : Form
    {
        string Role;
        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();

        double totalCost;
        double RoomCost;
        double tvCost;
        double phoneCost;
        double totalDays;
        double InsuranceCoverage;

        public frmBilling(string incomingRole)
        {
            InitializeComponent();
            Role = incomingRole;
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'dSPatients.SurgicalReport' table. You can move, or remove it, as needed.
            this.surgicalReportTableAdapter.Fill(this.dSPatients.SurgicalReport);
            // TODO: This line of code loads data into the 'dSPatients.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.dSPatients.Patients);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.txtTreatment.Clear();
            cn.Open();
            
            string thisAdmissionNumber = this.txtAdmissionNumber.Text;
            DateTime FirstDay;
            DateTime LastDay;
            
            

            using (SqlCommand cmd =
                new SqlCommand("SELECT AdmissionID, PatientID, BedNumber, SurgeryScheduled, AdmissionDate, SurgeryDate, DischargeDate, TV, Phone FROM AdmissionRecord WHERE AdmissionID = " + thisAdmissionNumber, cn))
                try
                {
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        txtTreatment.Text += sdr["BedNumber"].ToString() + "\r\n" + "Time in Hospital: " + sdr["AdmissionDate"].ToString()
                            + ", " + sdr["DischargeDate"].ToString() + "\r\n" + "Surguery date (if needed): " + sdr["SurgeryDate"].ToString() ;
                        
                        this.txtRoom.Text = sdr["BedNumber"].ToString();
                        txtHealthNumber.Text = sdr["PatientID"].ToString();
                        FirstDay = Convert.ToDateTime(sdr["AdmissionDate"].ToString());
                        LastDay = Convert.ToDateTime(sdr["DischargeDate"].ToString());
                        TimeSpan ts = LastDay - FirstDay;
                        totalDays = ts.Days;

                        if (sdr["TV"].ToString() == "True")
                        {
                            txtTreatment.Text += "\r\nPlus TV";
                            txtTV.Text = "Included";
                        }

                        if (sdr["Phone"].ToString() == "True")
                        {
                            txtTreatment.Text += "\r\nPlus Phone";
                            txtPhone.Text = "Included";
                        }
                    }
                    sdr.Close();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine(ex.Message);
                }

            using (SqlCommand cmd =
                new SqlCommand("SELECT ProcedureType FROM SurgicalReport WHERE HealthNumber = " + txtHealthNumber.Text, cn))
                
                try
                {
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        txtTreatment.Text += "\r\n" + sdr["ProcedureType"].ToString();
                    }
                    sdr.Close();
                    
                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine(ex.Message);
                }

            using (SqlCommand cmd =
                new SqlCommand("SELECT FirstName, Lastname, DateOfBirth, InsuranceNumberID FROM Patients WHERE HealthNumber = " + txtHealthNumber.Text, cn))
                

                try
                {

                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        txtDoB.Text = sdr["DateOfBirth"].ToString();
                        txtInsuranceN.Text = sdr["InsuranceNumberID"].ToString();
                        txtFirstName.Text = sdr["FirstName"].ToString();
                        txtLastName.Text = sdr["LastName"].ToString();
                        
                    }
                    sdr.Close();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine(ex.Message);
                }

            using (SqlCommand cmd =
                new SqlCommand("SELECT StreetAddress, Province, PostalCode FROM PrivateInformation WHERE HealthNumber = " + txtHealthNumber.Text, cn))
                
                try
                {
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        txtAddress.Text = sdr["StreetAddress"].ToString();
                        txtProvince.Text = sdr["Province"].ToString();
                        txtPostal.Text = sdr["PostalCode"].ToString();
                    }
                    sdr.Close();
                    


                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine(ex.Message);
                }

            
            string thisBedNumber = this.txtRoom.Text;
 
            using (SqlCommand cmd =
                new SqlCommand("SELECT BedType FROM Beds WHERE BedNumber = '" + thisBedNumber + "'", cn))
                try
                {
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {   
                        txtRoomType.Text = sdr["BedType"].ToString();
                        
                    }
                    sdr.Close();
                    
                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine(ex.Message);
                }

            using (SqlCommand cmd =
                new SqlCommand("SELECT DailyCost, AmenityName FROM Extra_Rates WHERE AmenityName= '" +txtRoomType.Text + "'", cn))
                try
                {
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    
                    RoomCost = sdr.GetDouble(sdr.GetOrdinal("DailyCost"));
                    
                    sdr.Close();

                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine(ex.Message);
                }

            if (txtTV.Text == "Included")
                    {
                        using (SqlCommand cmd =
                            new SqlCommand("SELECT DailyCost, AmenityName FROM Extra_Rates WHERE AmenityName= 'TV'" , cn))
                            try
                            {
                                SqlDataReader sdr = cmd.ExecuteReader();
                                sdr.Read();

                                tvCost = sdr.GetDouble(sdr.GetOrdinal("DailyCost"));
                                sdr.Close();
                            }
                            catch (Exception ex)
                            {
                                cn.Close();
                                Console.WriteLine(ex.Message);
                            }     
                        }

            if (txtPhone.Text == "Included")
            {
                using (SqlCommand cmd =
                    new SqlCommand("SELECT DailyCost, AmenityName FROM Extra_Rates WHERE AmenityName= 'Phone'", cn))
                    try
                    {
                        SqlDataReader sdr = cmd.ExecuteReader();
                        sdr.Read();
                        phoneCost = sdr.GetDouble(sdr.GetOrdinal("DailyCost"));
                        sdr.Close();
                    }
                    catch (Exception ex)
                    {                        
                        Console.WriteLine(ex.Message);
                        cn.Close();
                    }
            }

            using (SqlCommand cmd =
                new SqlCommand("SELECT InsuranceNumber, InsuranceCoverage FROM InsuranceCoverage WHERE InsuranceNumber= '" +txtInsuranceN.Text + "'", cn))
                try
                {
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {                       
                        InsuranceCoverage = sdr.GetDouble(sdr.GetOrdinal("InsuranceCoverage"));

                        txtTreatment.Text += "\r\n" + "Total Insurance coverage " + sdr["InsuranceCoverage"].ToString();
                    }
                    sdr.Close();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine(ex.Message);
                }



            if (txtInsuranceN.Text != "")
            {
                totalCost = ((RoomCost * totalDays) + (tvCost * totalDays) + (phoneCost * totalDays))*InsuranceCoverage;

                txtTotal.Text = "$" + totalCost.ToString();
            }
            else
            {
                totalCost = (RoomCost * totalDays) + (tvCost * totalDays) + (phoneCost * totalDays);
                txtTotal.Text = "$" + totalCost.ToString();
            }            

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseScreen();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            cn.Open();
            Random rnd = new Random();
            int billID = rnd.Next(1000, 9999);
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
                "SELECT BillID, BillDate, BillInfo FROM HospitalBills", cn);

            thisDataAdapter.Fill(thisDataSet, "HospitalBills");
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisDataAdapter);
            try
            {
                DataRow thisRow = thisDataSet.Tables["HospitalBills"].NewRow();
                thisRow["BillInfo"] = this.txtTreatment.Text;
                thisRow["BillID"] = billID.ToString();
                thisRow["BillDate"] = DateTime.Today;

                thisDataSet.Tables["HospitalBills"].Rows.Add(thisRow);

                //Call Update
                thisDataAdapter.Update(thisDataSet, "HospitalBills");
                cn.Close();
                MessageBox.Show(txtTreatment.Text + "\r\nTotal: " + txtTotal.Text);
            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmBilling_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseScreen();
        }
    }
}
