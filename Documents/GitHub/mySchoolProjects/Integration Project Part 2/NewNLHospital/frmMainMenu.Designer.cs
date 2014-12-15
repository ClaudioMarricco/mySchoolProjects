namespace NewNLHospital
{
    partial class frmMainMenu
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlDoctors = new System.Windows.Forms.Panel();
            this.btnSurgicalReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindPatient = new System.Windows.Forms.Button();
            this.pnlAdministrator = new System.Windows.Forms.Panel();
            this.btnBilling = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.pnlNurses = new System.Windows.Forms.Panel();
            this.btnWards = new System.Windows.Forms.Button();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPatientList = new System.Windows.Forms.Button();
            this.btnSurgeryReportViewer = new System.Windows.Forms.Button();
            this.lblNurses = new System.Windows.Forms.Label();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdmissions = new System.Windows.Forms.Button();
            this.btnResources = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDoctors.SuspendLayout();
            this.pnlAdministrator.SuspendLayout();
            this.pnlNurses.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(585, 435);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlDoctors
            // 
            this.pnlDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDoctors.Controls.Add(this.btnSurgicalReport);
            this.pnlDoctors.Controls.Add(this.label1);
            this.pnlDoctors.Controls.Add(this.txtPatientID);
            this.pnlDoctors.Controls.Add(this.label3);
            this.pnlDoctors.Controls.Add(this.btnDischarge);
            this.pnlDoctors.Controls.Add(this.label2);
            this.pnlDoctors.Location = new System.Drawing.Point(340, 12);
            this.pnlDoctors.Name = "pnlDoctors";
            this.pnlDoctors.Size = new System.Drawing.Size(320, 120);
            this.pnlDoctors.TabIndex = 6;
            this.pnlDoctors.Visible = false;
            // 
            // btnSurgicalReport
            // 
            this.btnSurgicalReport.Location = new System.Drawing.Point(168, 82);
            this.btnSurgicalReport.Name = "btnSurgicalReport";
            this.btnSurgicalReport.Size = new System.Drawing.Size(136, 23);
            this.btnSurgicalReport.TabIndex = 9;
            this.btnSurgicalReport.Text = "Surgical Report";
            this.btnSurgicalReport.Click += new System.EventHandler(this.btnSurgicalReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(80, 56);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(72, 20);
            this.txtPatientID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please select one of the following:";
            // 
            // btnDischarge
            // 
            this.btnDischarge.Location = new System.Drawing.Point(16, 80);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(136, 23);
            this.btnDischarge.TabIndex = 1;
            this.btnDischarge.Text = "Discharge Patient";
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doctors";
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.Location = new System.Drawing.Point(168, 51);
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(136, 23);
            this.btnFindPatient.TabIndex = 8;
            this.btnFindPatient.Text = "Find Patient";
            this.btnFindPatient.Click += new System.EventHandler(this.btnFindPatient_Click);
            // 
            // pnlAdministrator
            // 
            this.pnlAdministrator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdministrator.Controls.Add(this.btnBilling);
            this.pnlAdministrator.Controls.Add(this.lblAdmin);
            this.pnlAdministrator.Controls.Add(this.btnDoctors);
            this.pnlAdministrator.Controls.Add(this.lblAdministrator);
            this.pnlAdministrator.Location = new System.Drawing.Point(12, 12);
            this.pnlAdministrator.Name = "pnlAdministrator";
            this.pnlAdministrator.Size = new System.Drawing.Size(320, 120);
            this.pnlAdministrator.TabIndex = 5;
            this.pnlAdministrator.Visible = false;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(160, 80);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(136, 23);
            this.btnBilling.TabIndex = 5;
            this.btnBilling.Text = "Bill Patient";
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(16, 32);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(168, 13);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Please select one of the following:";
            // 
            // btnDoctors
            // 
            this.btnDoctors.Location = new System.Drawing.Point(8, 80);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(136, 23);
            this.btnDoctors.TabIndex = 1;
            this.btnDoctors.Text = "Manage Doctors";
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(16, 8);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(111, 17);
            this.lblAdministrator.TabIndex = 0;
            this.lblAdministrator.Text = "Administration";
            // 
            // pnlNurses
            // 
            this.pnlNurses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNurses.Controls.Add(this.btnWards);
            this.pnlNurses.Controls.Add(this.btnNewPatient);
            this.pnlNurses.Controls.Add(this.label4);
            this.pnlNurses.Controls.Add(this.btnPatientList);
            this.pnlNurses.Controls.Add(this.btnSurgeryReportViewer);
            this.pnlNurses.Controls.Add(this.lblNurses);
            this.pnlNurses.Location = new System.Drawing.Point(12, 140);
            this.pnlNurses.Name = "pnlNurses";
            this.pnlNurses.Size = new System.Drawing.Size(320, 120);
            this.pnlNurses.TabIndex = 7;
            this.pnlNurses.Visible = false;
            // 
            // btnWards
            // 
            this.btnWards.Location = new System.Drawing.Point(8, 51);
            this.btnWards.Name = "btnWards";
            this.btnWards.Size = new System.Drawing.Size(136, 23);
            this.btnWards.TabIndex = 7;
            this.btnWards.Text = "Wards";
            this.btnWards.Click += new System.EventHandler(this.btnWards_Click);
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Location = new System.Drawing.Point(160, 51);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(136, 23);
            this.btnNewPatient.TabIndex = 6;
            this.btnNewPatient.Text = "New Patient";
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Please select one of the following:";
            // 
            // btnPatientList
            // 
            this.btnPatientList.Location = new System.Drawing.Point(8, 80);
            this.btnPatientList.Name = "btnPatientList";
            this.btnPatientList.Size = new System.Drawing.Size(136, 23);
            this.btnPatientList.TabIndex = 2;
            this.btnPatientList.Text = "Patient List";
            this.btnPatientList.Click += new System.EventHandler(this.btnPatientList_Click);
            // 
            // btnSurgeryReportViewer
            // 
            this.btnSurgeryReportViewer.Location = new System.Drawing.Point(160, 80);
            this.btnSurgeryReportViewer.Name = "btnSurgeryReportViewer";
            this.btnSurgeryReportViewer.Size = new System.Drawing.Size(136, 23);
            this.btnSurgeryReportViewer.TabIndex = 1;
            this.btnSurgeryReportViewer.Text = "View Surgical Reports";
            this.btnSurgeryReportViewer.Click += new System.EventHandler(this.btnSurgeryReport_Click);
            // 
            // lblNurses
            // 
            this.lblNurses.AutoSize = true;
            this.lblNurses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNurses.Location = new System.Drawing.Point(16, 8);
            this.lblNurses.Name = "lblNurses";
            this.lblNurses.Size = new System.Drawing.Size(59, 17);
            this.lblNurses.TabIndex = 0;
            this.lblNurses.Text = "Nurses";
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGeneral.Controls.Add(this.label5);
            this.pnlGeneral.Controls.Add(this.btnFindPatient);
            this.pnlGeneral.Controls.Add(this.btnAdmissions);
            this.pnlGeneral.Controls.Add(this.btnResources);
            this.pnlGeneral.Controls.Add(this.label6);
            this.pnlGeneral.Location = new System.Drawing.Point(338, 140);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(320, 120);
            this.pnlGeneral.TabIndex = 8;
            this.pnlGeneral.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Please select one of the following:";
            // 
            // btnAdmissions
            // 
            this.btnAdmissions.Location = new System.Drawing.Point(16, 80);
            this.btnAdmissions.Name = "btnAdmissions";
            this.btnAdmissions.Size = new System.Drawing.Size(136, 23);
            this.btnAdmissions.TabIndex = 2;
            this.btnAdmissions.Text = "Admissions";
            this.btnAdmissions.Click += new System.EventHandler(this.btnAdmissions_Click);
            // 
            // btnResources
            // 
            this.btnResources.Location = new System.Drawing.Point(168, 80);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(136, 23);
            this.btnResources.TabIndex = 1;
            this.btnResources.Text = "Resources";
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "General";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(672, 470);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAdministrator);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pnlDoctors);
            this.Controls.Add(this.pnlNurses);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.pnlDoctors.ResumeLayout(false);
            this.pnlDoctors.PerformLayout();
            this.pnlAdministrator.ResumeLayout(false);
            this.pnlAdministrator.PerformLayout();
            this.pnlNurses.ResumeLayout(false);
            this.pnlNurses.PerformLayout();
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAdministrator;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Panel pnlNurses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPatientList;
        private System.Windows.Forms.Button btnSurgeryReportViewer;
        private System.Windows.Forms.Label lblNurses;
        private System.Windows.Forms.Button btnFindPatient;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdmissions;
        private System.Windows.Forms.Button btnResources;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnSurgicalReport;
        private System.Windows.Forms.Button btnWards;
    }
}