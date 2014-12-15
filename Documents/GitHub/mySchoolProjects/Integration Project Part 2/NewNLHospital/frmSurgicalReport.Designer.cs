namespace NewNLHospital
{
    partial class frmSurgicalReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSurgicalReport));
            this.label2 = new System.Windows.Forms.Label();
            this.txtHealthCareNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcedure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLeadSurgeon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dsPatients1 = new NewNLHospital.DSPatients();
            this.cboDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dsPatients1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Healthcare Number";
            // 
            // txtHealthCareNumber
            // 
            this.txtHealthCareNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtHealthCareNumber.Location = new System.Drawing.Point(228, 89);
            this.txtHealthCareNumber.Name = "txtHealthCareNumber";
            this.txtHealthCareNumber.Size = new System.Drawing.Size(131, 20);
            this.txtHealthCareNumber.TabIndex = 34;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(378, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Duration";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(12, 149);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(131, 20);
            this.txtDuration.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Procedure";
            // 
            // txtProcedure
            // 
            this.txtProcedure.Location = new System.Drawing.Point(12, 221);
            this.txtProcedure.Multiline = true;
            this.txtProcedure.Name = "txtProcedure";
            this.txtProcedure.Size = new System.Drawing.Size(347, 142);
            this.txtProcedure.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Lead Surgeon";
            // 
            // txtLeadSurgeon
            // 
            this.txtLeadSurgeon.BackColor = System.Drawing.SystemColors.Window;
            this.txtLeadSurgeon.Location = new System.Drawing.Point(12, 88);
            this.txtLeadSurgeon.Name = "txtLeadSurgeon";
            this.txtLeadSurgeon.Size = new System.Drawing.Size(131, 20);
            this.txtLeadSurgeon.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.Location = new System.Drawing.Point(228, 36);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(131, 20);
            this.txtLastName.TabIndex = 21;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Location = new System.Drawing.Point(12, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(131, 20);
            this.txtFirstName.TabIndex = 20;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     SurgicalReport.*\r\nFROM         SurgicalReport";
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
            // dsPatients1
            // 
            this.dsPatients1.DataSetName = "DSPatients";
            this.dsPatients1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboDate
            // 
            this.cboDate.Location = new System.Drawing.Point(228, 150);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(131, 20);
            this.cboDate.TabIndex = 36;
            // 
            // frmSurgicalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(465, 463);
            this.ControlBox = false;
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHealthCareNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProcedure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLeadSurgeon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmSurgicalReport";
            this.Text = "Surgical Report";
            this.Load += new System.EventHandler(this.frmSurgicalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPatients1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHealthCareNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcedure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLeadSurgeon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DSPatients dsPatients1;
        private System.Windows.Forms.DateTimePicker cboDate;
    }
}