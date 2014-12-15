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
    public partial class frmLogin : Form
    {
        string Role;
        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool CompareStrings(string string1, string string2)
        {
            return String.Compare(string1, string2, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {           
            cn.Open();
            try
            {               
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(UserName, '') AS UserName, ISNULL(UPassword,'') AS UPassword, ISNULL(Role,'') AS Role FROM Logins WHERE Username='" + txtUserID.Text + "' and UPassword='" + txtPassword.Text + "'", cn);

                SqlDataReader sdr = cmd.ExecuteReader();

                string userText = txtUserID.Text;
                string passText = txtPassword.Text;
                

                while (sdr.Read())
                {
                    if (this.CompareStrings(sdr["Username"].ToString(), userText) &&
                        this.CompareStrings(sdr["UPassword"].ToString(), passText))
                    {
                        Role = sdr["Role"].ToString();
                        frmMainMenu MainMenu = new frmMainMenu(Role);

                        MainMenu.Visible = true;
                        MainMenu.Activate();
                        MainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }

                sdr.Close();

                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
