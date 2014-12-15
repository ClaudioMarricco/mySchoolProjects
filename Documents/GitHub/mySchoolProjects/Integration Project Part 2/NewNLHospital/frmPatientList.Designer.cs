namespace NewNLHospital
{
    partial class frmPatientList
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
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPatients = new NewNLHospital.DSPatients();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.patientsTableAdapter = new NewNLHospital.DSPatientsTableAdapters.PatientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPatient
            // 
            this.lstPatient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstPatient.DataSource = this.patientsBindingSource;
            this.lstPatient.DisplayMember = "HealthNumber";
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.Location = new System.Drawing.Point(9, 21);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(215, 329);
            this.lstPatient.TabIndex = 0;
            this.lstPatient.SelectedIndexChanged += new System.EventHandler(this.lstPatient_SelectedIndexChanged);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.dSPatients;
            // 
            // dSPatients
            // 
            this.dSPatients.DataSetName = "DSPatients";
            this.dSPatients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "LastName", true));
            this.textBox1.Location = new System.Drawing.Point(387, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "FirstName", true));
            this.textBox2.Location = new System.Drawing.Point(233, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "PhoneNumber", true));
            this.textBox3.Location = new System.Drawing.Point(387, 272);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Relation", true));
            this.textBox4.Location = new System.Drawing.Point(387, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "NextOfKin", true));
            this.textBox5.Location = new System.Drawing.Point(233, 232);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "PostalCode", true));
            this.textBox6.Location = new System.Drawing.Point(387, 193);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 20);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Province", true));
            this.textBox7.Location = new System.Drawing.Point(233, 193);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(148, 20);
            this.textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "City", true));
            this.textBox8.Location = new System.Drawing.Point(387, 155);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(148, 20);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "StreetAddress", true));
            this.textBox9.Location = new System.Drawing.Point(233, 155);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(148, 20);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "DateOfBirth", true));
            this.textBox10.Location = new System.Drawing.Point(387, 115);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(148, 20);
            this.textBox10.TabIndex = 10;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Ward", true));
            this.textBox11.Location = new System.Drawing.Point(233, 115);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(148, 20);
            this.textBox11.TabIndex = 11;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "DoctorID", true));
            this.textBox12.Location = new System.Drawing.Point(387, 75);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(148, 20);
            this.textBox12.TabIndex = 12;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "InsuranceNumberID", true));
            this.textBox13.Location = new System.Drawing.Point(233, 75);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(148, 20);
            this.textBox13.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Insurance Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Doctor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Current Ward";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "City";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Province";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Postal Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Next of kin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(388, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Relation";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(384, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Phone Number";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(460, 327);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     Patients.*, PrivateInformation.*\r\nFROM         Patients INNER JOIN\r\n  " +
                "                    PrivateInformation ON Patients.InsuranceNumber = PrivateInfo" +
                "rmation.InsuranceNumberID";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=CMARRICCO;Initial Catalog=NLHospital;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
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
                        new System.Data.Common.DataColumnMapping("InsuranceNumberID", "InsuranceNumberID"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Province", "Province"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber"),
                        new System.Data.Common.DataColumnMapping("NextOfKin", "NextOfKin"),
                        new System.Data.Common.DataColumnMapping("Relation", "Relation")})});
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // frmPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 398);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstPatient);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmPatientList";
            this.Text = "PatientList";
            this.Load += new System.EventHandler(this.frmPatientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private DSPatients dSPatients;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private NewNLHospital.DSPatientsTableAdapters.PatientsTableAdapter patientsTableAdapter;
    }
}