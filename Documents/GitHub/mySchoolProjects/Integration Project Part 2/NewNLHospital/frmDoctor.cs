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
    public partial class frmDoctor : Form
    {
        string Role;
        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();

        public frmDoctor(string incomingRole)
        {
            InitializeComponent();
            Role = incomingRole;
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            // TODO: This line of code loads data into the 'dsPatients1.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.dsPatients1.Doctors);

        }

        private void CloseScreen()
        {
            this.Close();
            frmMainMenu MainMenu = new frmMainMenu(Role);
            MainMenu.Visible = true;
            MainMenu.Activate();
            MainMenu.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            CloseScreen();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.txtDoctorID.Clear();
            this.txtDrFirstName.Clear();
            this.txtDrLastName.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cn.Open();
            Random rnd = new Random();
            int uPassword = rnd.Next(1000, 9999);
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
               "SELECT DoctorID, DrFirstName, DrLastName, Specialty FROM Doctors", cn);
            SqlDataAdapter thisDataAdapter1 = new SqlDataAdapter(
               "SELECT UserName, UPassword, Role FROM Logins", cn);

            thisDataAdapter.Fill(thisDataSet, "Doctors");
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisDataAdapter);
            try
            {
                DataRow thisRow = thisDataSet.Tables["Doctors"].NewRow();
                thisRow["DoctorID"] = this.txtDoctorID.Text;
                thisRow["DrFirstName"] = this.txtDrFirstName.Text;
                thisRow["DrLastName"] = this.txtDrLastName.Text;
                thisRow["Specialty"] = this.cboSpecialty.SelectedItem.ToString();

                thisDataSet.Tables["Doctors"].Rows.Add(thisRow);

                //Call Update
                thisDataAdapter.Update(thisDataSet, "Doctors");  
                
            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }            

            thisDataAdapter1.Fill(thisDataSet, "Logins");
            SqlCommandBuilder thisBuilder1 = new SqlCommandBuilder(thisDataAdapter1);
            try
            {
                DataRow thisRow = thisDataSet.Tables["Logins"].NewRow();
                thisRow["UserName"] = this.txtDrLastName.Text;
                thisRow["Role"] = "Doctor";
                thisRow["UPassword"] = uPassword.ToString();

                thisDataSet.Tables["Logins"].Rows.Add(thisRow);

                //Call Update
                thisDataAdapter1.Update(thisDataSet, "Logins");
                MessageBox.Show("New Doctor Added" + "\r\nPassword: " + uPassword);
                cn.Close();
            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }


        }

        private void dgDoctors_Navigate(object sender, NavigateEventArgs ne)
        {
            this.BindingContext[this.dsPatients1, "Doctors"].Position =
                this.dgvDoctors.CurrentCell.RowIndex;
        }

        private void txtDoctorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
               "SELECT DoctorID, DrFirstName, DrLastName, Specialty FROM Doctors", cn);

            string thisDoctorID = this.txtDoctorID.Text;


            using (SqlCommand cmd =
                new SqlCommand("UPDATE Doctors SET DrFirstName=@DrFirstName, DrLastName=@DrLastName, Specialty=@Specialty WHERE DoctorID=@DoctorID", cn))
                try
                {
                    cmd.Parameters.AddWithValue("@DoctorID", thisDoctorID);
                    cmd.Parameters.AddWithValue("@DrFirstName", txtDrFirstName.Text);
                    cmd.Parameters.AddWithValue("@DrLastName", txtDrLastName.Text);
                    cmd.Parameters.AddWithValue("@Specialty", this.cboSpecialty.SelectedItem.ToString());

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.dgvDoctors.DataSource = doctorsBindingSource;
            this.dgvDoctors.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
               "SELECT DoctorID, DrFirstName, DrLastName, Specialty FROM Doctors", cn);

            string thisDoctorID = this.txtDoctorID.Text;


            using (SqlCommand cmd =
                new SqlCommand("DELETE FROM Doctors WHERE DrFirstName= '" +txtDrFirstName.Text + "' AND DrLastName= '" +txtDrLastName.Text + "' AND Specialty= '" +cboSpecialty.Text+ "' AND DoctorID= '" +txtDoctorID.Text+"'" , cn))
                try
                {
                    cmd.Parameters.AddWithValue("@DoctorID", thisDoctorID);
                    cmd.Parameters.AddWithValue("@DrFirstName", txtDrFirstName.Text);
                    cmd.Parameters.AddWithValue("@DrLastName", txtDrLastName.Text);
                    cmd.Parameters.AddWithValue("@Specialty", this.cboSpecialty.Text);

                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Doctor Data Deleted");
                }
                catch (Exception ex)
                {
                    cn.Close();
                    Console.WriteLine(ex.Message);
                }
        }

        private void frmDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseScreen();
        }
    }
}
