namespace NewNLHospital
{
    partial class frmNewPatient
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtHCNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRelation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNoKin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhoneN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.comboWard = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dsPatients1 = new NewNLHospital.DSPatients();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.cboInsurances = new System.Windows.Forms.ComboBox();
            this.cboDoctors = new System.Windows.Forms.ComboBox();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new NewNLHospital.DSPatientsTableAdapters.DoctorsTableAdapter();
            this.doctorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.insuranceCoverageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insuranceCoverageTableAdapter = new NewNLHospital.DSPatientsTableAdapters.InsuranceCoverageTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPatients1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCoverageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(6, 26);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(247, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(259, 26);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(247, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtHCNumber
            // 
            this.txtHCNumber.Location = new System.Drawing.Point(6, 26);
            this.txtHCNumber.Name = "txtHCNumber";
            this.txtHCNumber.Size = new System.Drawing.Size(247, 20);
            this.txtHCNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "HealthCare Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doctor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Insurance Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Province";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Address";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(259, 26);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(247, 20);
            this.txtCity.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(6, 26);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(247, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Postal Code";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(258, 66);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(247, 20);
            this.txtPostalCode.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Relation";
            // 
            // txtRelation
            // 
            this.txtRelation.Location = new System.Drawing.Point(258, 26);
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(247, 20);
            this.txtRelation.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Next of kin name";
            // 
            // txtNoKin
            // 
            this.txtNoKin.Location = new System.Drawing.Point(6, 26);
            this.txtNoKin.Name = "txtNoKin";
            this.txtNoKin.Size = new System.Drawing.Size(247, 20);
            this.txtNoKin.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Phone Number";
            // 
            // txtPhoneN
            // 
            this.txtPhoneN.Location = new System.Drawing.Point(6, 65);
            this.txtPhoneN.Name = "txtPhoneN";
            this.txtPhoneN.Size = new System.Drawing.Size(247, 20);
            this.txtPhoneN.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(10, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 100);
            this.panel1.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboDoctors);
            this.panel2.Controls.Add(this.cboInsurances);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.comboWard);
            this.panel2.Controls.Add(this.txtHCNumber);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(10, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 100);
            this.panel2.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Ward";
            // 
            // comboWard
            // 
            this.comboWard.FormattingEnabled = true;
            this.comboWard.Items.AddRange(new object[] {
            "General",
            "Cardiac Unit ",
            "Intensive Care Unit ",
            "Pediatric Unit ",
            "Medical Unit ",
            "Cancer Unit ",
            "Geriatric Unit ",
            "Surgical Unit ",
            "Obstetric and Gynecology Unit ",
            "Neonatal Intensive Care Unit ",
            "Pediatric Intensive Care Unit ",
            "Neurology Unit ",
            "Psychiatric Unit ",
            "Urology Unit",
            "Discharged"});
            this.comboWard.Location = new System.Drawing.Point(258, 65);
            this.comboWard.Name = "comboWard";
            this.comboWard.Size = new System.Drawing.Size(246, 21);
            this.comboWard.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cboProvince);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.txtCity);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtPostalCode);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(10, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 100);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtNoKin);
            this.panel4.Controls.Add(this.txtRelation);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtPhoneN);
            this.panel4.Location = new System.Drawing.Point(10, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 100);
            this.panel4.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(374, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(455, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     Patients.*, PrivateInformation.*\r\nFROM         Patients INNER JOIN\r\n  " +
                "                    PrivateInformation ON Patients.InsuranceNumber = PrivateInfo" +
                "rmation.InsuranceNumber";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=CMARRICCO;Initial Catalog=NLHospital;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage_2);
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Patients", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("HealthNumber", "HealthNumber"),
                        new System.Data.Common.DataColumnMapping("DateOfBirth", "DateOfBirth"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("InsuranceNumber", "InsuranceNumber"),
                        new System.Data.Common.DataColumnMapping("DoctorID", "DoctorID"),
                        new System.Data.Common.DataColumnMapping("Ward", "Ward"),
                        new System.Data.Common.DataColumnMapping("InsuranceNumber1", "InsuranceNumber1"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Province", "Province"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber"),
                        new System.Data.Common.DataColumnMapping("NextOfKin", "NextOfKin"),
                        new System.Data.Common.DataColumnMapping("Relation", "Relation")})});
            // 
            // dsPatients1
            // 
            this.dsPatients1.DataSetName = "DSPatients";
            this.dsPatients1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboProvince
            // 
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "Alberta",
            "British Columbia",
            "Manitoba",
            "New Brunswick",
            "Newfoundland and Labrador",
            "Nova Scotia",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan",
            "Nunavut",
            "Northwest Territories",
            "Yukon"});
            this.cboProvince.Location = new System.Drawing.Point(6, 64);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(247, 21);
            this.cboProvince.TabIndex = 20;
            // 
            // cboInsurances
            // 
            this.cboInsurances.AutoCompleteCustomSource.AddRange(new string[] {
            "112233",
            "445566",
            "778899"});
            this.cboInsurances.DataSource = this.insuranceCoverageBindingSource;
            this.cboInsurances.DisplayMember = "InsuranceNumber";
            this.cboInsurances.FormattingEnabled = true;
            this.cboInsurances.Location = new System.Drawing.Point(258, 26);
            this.cboInsurances.Name = "cboInsurances";
            this.cboInsurances.Size = new System.Drawing.Size(246, 21);
            this.cboInsurances.TabIndex = 14;
            // 
            // cboDoctors
            // 
            this.cboDoctors.DataSource = this.doctorsBindingSource1;
            this.cboDoctors.DisplayMember = "DoctorID";
            this.cboDoctors.FormattingEnabled = true;
            this.cboDoctors.Location = new System.Drawing.Point(6, 67);
            this.cboDoctors.Name = "cboDoctors";
            this.cboDoctors.Size = new System.Drawing.Size(247, 21);
            this.cboDoctors.TabIndex = 15;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.dsPatients1;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsBindingSource1
            // 
            this.doctorsBindingSource1.DataMember = "Doctors";
            this.doctorsBindingSource1.DataSource = this.dsPatients1;
            // 
            // insuranceCoverageBindingSource
            // 
            this.insuranceCoverageBindingSource.DataMember = "InsuranceCoverage";
            this.insuranceCoverageBindingSource.DataSource = this.dsPatients1;
            // 
            // insuranceCoverageTableAdapter
            // 
            this.insuranceCoverageTableAdapter.ClearBeforeFill = true;
            // 
            // frmNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 463);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmNewPatient";
            this.Text = " New Patient";
            this.Load += new System.EventHandler(this.NewPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPatients1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCoverageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtHCNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRelation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNoKin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPhoneN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboWard;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private DSPatients dsPatients1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.ComboBox cboInsurances;
        private System.Windows.Forms.ComboBox cboDoctors;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private NewNLHospital.DSPatientsTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.BindingSource doctorsBindingSource1;
        private System.Windows.Forms.BindingSource insuranceCoverageBindingSource;
        private NewNLHospital.DSPatientsTableAdapters.InsuranceCoverageTableAdapter insuranceCoverageTableAdapter;
    }
}