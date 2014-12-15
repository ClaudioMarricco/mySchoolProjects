namespace NewNLHospital
{
    partial class frmSurgicalReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSurgicalReportViewer));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dSPatients = new NewNLHospital.DSPatients();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcedure = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lstSurgical = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SurgicalReportTableAdapter = new NewNLHospital.DSPatientsTableAdapters.SurgicalReportTableAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHealthCareNumber = new System.Windows.Forms.TextBox();
            this.cboDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPatients, "SurgicalReport.FirstName", true));
            this.textBox1.Location = new System.Drawing.Point(21, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dSPatients
            // 
            this.dSPatients.DataSetName = "DSPatients";
            this.dSPatients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPatients, "SurgicalReport.LastName", true));
            this.textBox3.Location = new System.Drawing.Point(158, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lead Surgeon";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPatients, "SurgicalReport.LeadSurgeonID", true));
            this.textBox4.Location = new System.Drawing.Point(21, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Procedure";
            // 
            // txtProcedure
            // 
            this.txtProcedure.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPatients, "SurgicalReport.ProcedureType", true));
            this.txtProcedure.Location = new System.Drawing.Point(21, 226);
            this.txtProcedure.Multiline = true;
            this.txtProcedure.Name = "txtProcedure";
            this.txtProcedure.Size = new System.Drawing.Size(267, 121);
            this.txtProcedure.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Duration";
            // 
            // txtDuration
            // 
            this.txtDuration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPatients, "SurgicalReport.Duration", true));
            this.txtDuration.Location = new System.Drawing.Point(21, 177);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(131, 20);
            this.txtDuration.TabIndex = 12;
            // 
            // lstSurgical
            // 
            this.lstSurgical.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstSurgical.DataSource = this.dSPatients;
            this.lstSurgical.DisplayMember = "SurgicalReport.HealthNumber";
            this.lstSurgical.FormattingEnabled = true;
            this.lstSurgical.Location = new System.Drawing.Point(306, 25);
            this.lstSurgical.Name = "lstSurgical";
            this.lstSurgical.Size = new System.Drawing.Size(226, 381);
            this.lstSurgical.TabIndex = 14;
            this.lstSurgical.SelectedIndexChanged += new System.EventHandler(this.lstSurgical_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(21, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(214, 383);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=CMARRICCO;Initial Catalog=NLHospital;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // SurgicalReportTableAdapter
            // 
            this.SurgicalReportTableAdapter.ClearBeforeFill = true;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     SurgicalReport.*\r\nFROM         SurgicalReport";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@HealthNumber", System.Data.SqlDbType.NVarChar, 0, "HealthNumber"),
            new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 0, "LastName"),
            new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 0, "FirstName"),
            new System.Data.SqlClient.SqlParameter("@LeadSurgeonID", System.Data.SqlDbType.NVarChar, 0, "LeadSurgeonID"),
            new System.Data.SqlClient.SqlParameter("@ProcedureType", System.Data.SqlDbType.NVarChar, 0, "ProcedureType"),
            new System.Data.SqlClient.SqlParameter("@DatePerformed", System.Data.SqlDbType.NVarChar, 0, "DatePerformed"),
            new System.Data.SqlClient.SqlParameter("@Duration", System.Data.SqlDbType.NVarChar, 0, "Duration")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SurgicalReport", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("HealthNumber", "HealthNumber"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("LeadSurgeonID", "LeadSurgeonID"),
                        new System.Data.Common.DataColumnMapping("ProcedureType", "ProcedureType"),
                        new System.Data.Common.DataColumnMapping("DatePerformed", "DatePerformed"),
                        new System.Data.Common.DataColumnMapping("Duration", "Duration")})});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Healthcare Number";
            // 
            // txtHealthCareNumber
            // 
            this.txtHealthCareNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtHealthCareNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSPatients, "SurgicalReport.HealthNumber", true));
            this.txtHealthCareNumber.Location = new System.Drawing.Point(158, 84);
            this.txtHealthCareNumber.Name = "txtHealthCareNumber";
            this.txtHealthCareNumber.Size = new System.Drawing.Size(131, 20);
            this.txtHealthCareNumber.TabIndex = 18;
            // 
            // cboDate
            // 
            this.cboDate.Location = new System.Drawing.Point(21, 139);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(131, 20);
            this.cboDate.TabIndex = 20;
            // 
            // frmSurgicalReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 463);
            this.ControlBox = false;
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHealthCareNumber);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstSurgical);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProcedure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmSurgicalReportViewer";
            this.Text = "Surgical Report Viewer";
            this.Load += new System.EventHandler(this.frmSergicalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcedure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.ListBox lstSurgical;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private DSPatients dSPatients;
        private NewNLHospital.DSPatientsTableAdapters.SurgicalReportTableAdapter SurgicalReportTableAdapter;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHealthCareNumber;
        private System.Windows.Forms.DateTimePicker cboDate;
    }
}