namespace NewNLHospital
{
    partial class frmBilling
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHealthNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsuranceN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdmissionNumber = new System.Windows.Forms.TextBox();
            this.lblHealthCareNumber = new System.Windows.Forms.Label();
            this.dSPatients = new NewNLHospital.DSPatients();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new NewNLHospital.DSPatientsTableAdapters.PatientsTableAdapter();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.surgicalReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surgicalReportTableAdapter = new NewNLHospital.DSPatientsTableAdapters.SurgicalReportTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgicalReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHealthNumber);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtDoB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAdmissionNumber);
            this.panel1.Controls.Add(this.lblHealthCareNumber);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 221);
            this.panel1.TabIndex = 16;
            // 
            // txtHealthNumber
            // 
            this.txtHealthNumber.Location = new System.Drawing.Point(14, 65);
            this.txtHealthNumber.Name = "txtHealthNumber";
            this.txtHealthNumber.ReadOnly = true;
            this.txtHealthNumber.Size = new System.Drawing.Size(125, 20);
            this.txtHealthNumber.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Health Number";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtRoomType);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtPhone);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtTV);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtRoom);
            this.panel3.Location = new System.Drawing.Point(475, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 205);
            this.panel3.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Type";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(8, 140);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.Size = new System.Drawing.Size(100, 20);
            this.txtRoomType.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(7, 101);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "TV";
            // 
            // txtTV
            // 
            this.txtTV.Location = new System.Drawing.Point(6, 61);
            this.txtTV.Name = "txtTV";
            this.txtTV.ReadOnly = true;
            this.txtTV.Size = new System.Drawing.Size(100, 20);
            this.txtTV.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Room";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(5, 22);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.Size = new System.Drawing.Size(100, 20);
            this.txtRoom.TabIndex = 33;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(140, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 31;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtProvince);
            this.panel2.Controls.Add(this.txtPostal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtInsuranceN);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(221, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 205);
            this.panel2.TabIndex = 17;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(13, 101);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.ReadOnly = true;
            this.txtProvince.Size = new System.Drawing.Size(145, 20);
            this.txtProvince.TabIndex = 20;
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(13, 146);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.ReadOnly = true;
            this.txtPostal.Size = new System.Drawing.Size(145, 20);
            this.txtPostal.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Postal Code";
            // 
            // txtInsuranceN
            // 
            this.txtInsuranceN.Location = new System.Drawing.Point(13, 22);
            this.txtInsuranceN.Name = "txtInsuranceN";
            this.txtInsuranceN.ReadOnly = true;
            this.txtInsuranceN.Size = new System.Drawing.Size(201, 20);
            this.txtInsuranceN.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Insurance #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Province";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(13, 61);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(201, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address";
            // 
            // txtDoB
            // 
            this.txtDoB.Location = new System.Drawing.Point(13, 185);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.ReadOnly = true;
            this.txtDoB.Size = new System.Drawing.Size(100, 20);
            this.txtDoB.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date of Birth";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(13, 143);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(125, 20);
            this.txtLastName.TabIndex = 22;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(13, 104);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(125, 20);
            this.txtFirstName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "First Name";
            // 
            // txtAdmissionNumber
            // 
            this.txtAdmissionNumber.Location = new System.Drawing.Point(13, 25);
            this.txtAdmissionNumber.Name = "txtAdmissionNumber";
            this.txtAdmissionNumber.Size = new System.Drawing.Size(125, 20);
            this.txtAdmissionNumber.TabIndex = 17;
            // 
            // lblHealthCareNumber
            // 
            this.lblHealthCareNumber.AutoSize = true;
            this.lblHealthCareNumber.Location = new System.Drawing.Point(10, 9);
            this.lblHealthCareNumber.Name = "lblHealthCareNumber";
            this.lblHealthCareNumber.Size = new System.Drawing.Size(94, 13);
            this.lblHealthCareNumber.TabIndex = 16;
            this.lblHealthCareNumber.Text = "Admission Number";
            // 
            // dSPatients
            // 
            this.dSPatients.DataSetName = "DSPatients";
            this.dSPatients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.dSPatients;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(8, 239);
            this.txtTreatment.Multiline = true;
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(653, 121);
            this.txtTreatment.TabIndex = 17;
            // 
            // surgicalReportBindingSource
            // 
            this.surgicalReportBindingSource.DataMember = "SurgicalReport";
            this.surgicalReportBindingSource.DataSource = this.dSPatients;
            // 
            // surgicalReportTableAdapter
            // 
            this.surgicalReportTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(481, 366);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(180, 20);
            this.txtTotal.TabIndex = 28;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(586, 398);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 23);
            this.btnBill.TabIndex = 29;
            this.btnBill.Text = "Process";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(481, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(673, 425);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTreatment);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmBilling";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.frmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgicalReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDoB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdmissionNumber;
        private System.Windows.Forms.Label lblHealthCareNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtInsuranceN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private DSPatients dSPatients;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private NewNLHospital.DSPatientsTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.BindingSource surgicalReportBindingSource;
        private NewNLHospital.DSPatientsTableAdapters.SurgicalReportTableAdapter surgicalReportTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtHealthNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProvince;
    }
}