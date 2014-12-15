namespace NewNLHospital
{
    partial class frmAdmissionDetail
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
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboBed = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkSurScheduled = new System.Windows.Forms.CheckBox();
            this.admissionRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPatients = new NewNLHospital.DSPatients();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.admissionRecordTableAdapter = new NewNLHospital.DSPatientsTableAdapters.AdmissionRecordTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admissionRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Location = new System.Drawing.Point(110, 24);
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.ReadOnly = true;
            this.txtAdmissionID.Size = new System.Drawing.Size(122, 20);
            this.txtAdmissionID.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(243, 280);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(110, 50);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(122, 20);
            this.txtPatientID.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Patient ID";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(110, 76);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker3.TabIndex = 44;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(110, 102);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker2.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // cboBed
            // 
            this.cboBed.FormattingEnabled = true;
            this.cboBed.Items.AddRange(new object[] {
            "Car01",
            "Car02",
            "Car03",
            "Int01",
            "Int02",
            "Int03",
            "Int04",
            "Ped01",
            "Ped02",
            "Ped03",
            "Ped04",
            "Med01",
            "Med02",
            "Med03",
            "Can01",
            "Can02",
            "Can03",
            "Can04",
            "Ger01",
            "Ger02",
            "Ger03",
            "Sur01",
            "Sur02",
            "Sur03",
            "ObGy01",
            "ObGy02",
            "Neo01",
            "PedI01",
            "Neu01",
            "Psy01",
            "Uro01"});
            this.cboBed.Location = new System.Drawing.Point(110, 153);
            this.cboBed.Name = "cboBed";
            this.cboBed.Size = new System.Drawing.Size(100, 21);
            this.cboBed.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chkSurScheduled);
            this.panel2.Location = new System.Drawing.Point(32, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 43);
            this.panel2.TabIndex = 40;
            // 
            // chkSurScheduled
            // 
            this.chkSurScheduled.AutoSize = true;
            this.chkSurScheduled.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.admissionRecordBindingSource, "SurgeryScheduled", true));
            this.chkSurScheduled.Location = new System.Drawing.Point(18, 12);
            this.chkSurScheduled.Name = "chkSurScheduled";
            this.chkSurScheduled.Size = new System.Drawing.Size(116, 17);
            this.chkSurScheduled.TabIndex = 13;
            this.chkSurScheduled.Text = "Surgery Scheduled";
            this.chkSurScheduled.UseVisualStyleBackColor = true;
            // 
            // admissionRecordBindingSource
            // 
            this.admissionRecordBindingSource.DataMember = "AdmissionRecord";
            this.admissionRecordBindingSource.DataSource = this.dSPatients;
            // 
            // dSPatients
            // 
            this.dSPatients.DataSetName = "DSPatients";
            this.dSPatients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Bed #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Release Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Surgery Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Admission Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Admission ID";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(157, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // admissionRecordTableAdapter
            // 
            this.admissionRecordTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdmissionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(330, 315);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboBed);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAdmissionID);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmAdmissionDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdmissionDetail";
            this.Load += new System.EventHandler(this.frmAdmissionDetail_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admissionRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdmissionID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboBed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkSurScheduled;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private DSPatients dSPatients;
        private System.Windows.Forms.BindingSource admissionRecordBindingSource;
        private NewNLHospital.DSPatientsTableAdapters.AdmissionRecordTableAdapter admissionRecordTableAdapter;
    }
}