namespace NewNLHospital
{
    partial class frmDoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboSpecialty = new System.Windows.Forms.ComboBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.txtDrFirstName = new System.Windows.Forms.TextBox();
            this.txtDrLastName = new System.Windows.Forms.TextBox();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPatients1 = new NewNLHospital.DSPatients();
            this.doctorsTableAdapter = new NewNLHospital.DSPatientsTableAdapters.DoctorsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPatients1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cboSpecialty);
            this.panel1.Controls.Add(this.lblSpecialty);
            this.panel1.Controls.Add(this.lblFName);
            this.panel1.Controls.Add(this.lblLName);
            this.panel1.Controls.Add(this.lblDoctorID);
            this.panel1.Controls.Add(this.txtDrFirstName);
            this.panel1.Controls.Add(this.txtDrLastName);
            this.panel1.Controls.Add(this.txtDoctorID);
            this.panel1.Location = new System.Drawing.Point(15, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 136);
            this.panel1.TabIndex = 25;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(312, 37);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(312, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboSpecialty
            // 
            this.cboSpecialty.Items.AddRange(new object[] {
            "Anesthesiologist",
            "Cardiothoracic anesthesiology",
            "Emergency medicine",
            "Family medicine",
            "General surgery",
            "Internal medicine",
            "Medical genetics",
            "Neurosociology",
            "Neurosurgery",
            "Obstetrics and gynaecology",
            "Ophthalmology",
            "Orthopedic surgery",
            "Otolaryngology",
            "Pediatrics",
            "Plastic surgery",
            "Preventive medicine",
            "Radiation therapy",
            "Radiology",
            "Urology"});
            this.cboSpecialty.Location = new System.Drawing.Point(88, 82);
            this.cboSpecialty.Name = "cboSpecialty";
            this.cboSpecialty.Size = new System.Drawing.Size(168, 21);
            this.cboSpecialty.TabIndex = 27;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(8, 85);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(50, 13);
            this.lblSpecialty.TabIndex = 26;
            this.lblSpecialty.Text = "Specialty";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(8, 58);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 25;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(8, 34);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 24;
            this.lblLName.Text = "Last Name:";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Location = new System.Drawing.Point(8, 10);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(56, 13);
            this.lblDoctorID.TabIndex = 23;
            this.lblDoctorID.Text = "Doctor ID:";
            // 
            // txtDrFirstName
            // 
            this.txtDrFirstName.Location = new System.Drawing.Point(88, 58);
            this.txtDrFirstName.MaxLength = 20;
            this.txtDrFirstName.Name = "txtDrFirstName";
            this.txtDrFirstName.Size = new System.Drawing.Size(168, 20);
            this.txtDrFirstName.TabIndex = 22;
            // 
            // txtDrLastName
            // 
            this.txtDrLastName.Location = new System.Drawing.Point(88, 34);
            this.txtDrLastName.MaxLength = 20;
            this.txtDrLastName.Name = "txtDrLastName";
            this.txtDrLastName.Size = new System.Drawing.Size(168, 20);
            this.txtDrLastName.TabIndex = 21;
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(88, 10);
            this.txtDoctorID.MaxLength = 4;
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorID.TabIndex = 20;
            this.txtDoctorID.TextChanged += new System.EventHandler(this.txtDoctorID_TextChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(457, 349);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 22;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     Doctors.*\r\nFROM         Doctors";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=CMARRICCO;Initial Catalog=NLHospital;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@DoctorID", System.Data.SqlDbType.NVarChar, 0, "DoctorID"),
            new System.Data.SqlClient.SqlParameter("@DrLastName", System.Data.SqlDbType.NVarChar, 0, "DrLastName"),
            new System.Data.SqlClient.SqlParameter("@DrFirstName", System.Data.SqlDbType.NVarChar, 0, "DrFirstName"),
            new System.Data.SqlClient.SqlParameter("@Specialty", System.Data.SqlDbType.NVarChar, 0, "Specialty")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@DoctorID", System.Data.SqlDbType.NVarChar, 0, "DoctorID"),
            new System.Data.SqlClient.SqlParameter("@DrLastName", System.Data.SqlDbType.NVarChar, 0, "DrLastName"),
            new System.Data.SqlClient.SqlParameter("@DrFirstName", System.Data.SqlDbType.NVarChar, 0, "DrFirstName"),
            new System.Data.SqlClient.SqlParameter("@Specialty", System.Data.SqlDbType.NVarChar, 0, "Specialty"),
            new System.Data.SqlClient.SqlParameter("@Original_DoctorID", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DrLastName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DrLastName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DrLastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DrLastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DrFirstName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DrFirstName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DrFirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DrFirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Specialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Specialty", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Specialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Specialty", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_DoctorID", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DrLastName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DrLastName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DrLastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DrLastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DrFirstName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DrFirstName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DrFirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DrFirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Specialty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Specialty", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Specialty", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Specialty", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Doctors", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("DoctorID", "DoctorID"),
                        new System.Data.Common.DataColumnMapping("DrLastName", "DrLastName"),
                        new System.Data.Common.DataColumnMapping("DrFirstName", "DrFirstName"),
                        new System.Data.Common.DataColumnMapping("Specialty", "Specialty")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AutoGenerateColumns = false;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.drLastNameDataGridViewTextBoxColumn,
            this.drFirstNameDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn});
            this.dgvDoctors.DataSource = this.doctorsBindingSource;
            this.dgvDoctors.Location = new System.Drawing.Point(15, 12);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.Size = new System.Drawing.Size(416, 225);
            this.dgvDoctors.TabIndex = 26;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // drLastNameDataGridViewTextBoxColumn
            // 
            this.drLastNameDataGridViewTextBoxColumn.DataPropertyName = "DrLastName";
            this.drLastNameDataGridViewTextBoxColumn.HeaderText = "DrLastName";
            this.drLastNameDataGridViewTextBoxColumn.Name = "drLastNameDataGridViewTextBoxColumn";
            // 
            // drFirstNameDataGridViewTextBoxColumn
            // 
            this.drFirstNameDataGridViewTextBoxColumn.DataPropertyName = "DrFirstName";
            this.drFirstNameDataGridViewTextBoxColumn.HeaderText = "DrFirstName";
            this.drFirstNameDataGridViewTextBoxColumn.Name = "drFirstNameDataGridViewTextBoxColumn";
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.dsPatients1;
            // 
            // dsPatients1
            // 
            this.dsPatients1.DataSetName = "DSPatients";
            this.dsPatients1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 398);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuit);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmDoctor";
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPatients1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboSpecialty;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.TextBox txtDrFirstName;
        private System.Windows.Forms.TextBox txtDrLastName;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Button btnQuit;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DSPatients dsPatients1;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private NewNLHospital.DSPatientsTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
    }
}