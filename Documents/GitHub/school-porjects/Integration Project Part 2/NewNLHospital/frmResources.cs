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
    public partial class frmResources : Form
    {
        string Role;
        SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Integrated Security=SSPI;" +
            "Initial Catalog=NLHospital");

        DataSet thisDataSet = new DataSet();
        SqlCommand cmd = new SqlCommand();

        public frmResources(string incomingRole)
        {
            InitializeComponent();
            Role = incomingRole;
        }

        private void frmResources_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPatients.Beds' table. You can move, or remove it, as needed.
            this.bedsTableAdapter.Fill(this.dSPatients.Beds);
            cmd.Connection = cn;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            cn.Open();
            
              SqlDataAdapter thisDataAdapter = new SqlDataAdapter(
                "SELECT BedNumber, Occupied FROM Beds", cn);

            string thisBedNumber = this.txtBedNumber.Text;

            using (SqlCommand cmd =
                new SqlCommand("UPDATE Beds SET Occupied=@Occupied WHERE BedNumber=@BedNumber", cn))
                try
                {
                    cmd.Parameters.AddWithValue("@BedNumber", thisBedNumber);
                    bool i = false;
                    if (chkOccupied.Checked)
                    {
                        i = true;
                    }

                    cmd.Parameters.AddWithValue("@Occupied", i.ToString());
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Update Complete");
                }
            
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void frmResources_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseScreen();
        }
    }
}
