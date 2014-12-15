namespace NewNLHospital
{
    partial class btnQuit
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
            this.dgvAdmission = new System.Windows.Forms.DataGridView();
            this.admissionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surgeryScheduledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.admissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surgeryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dischargeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPatients = new NewNLHospital.DSPatients();
            this.admissionRecordTableAdapter = new NewNLHospital.DSPatientsTableAdapters.AdmissionRecordTableAdapter();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboBed = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkSurScheduled = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkPhone = new System.Windows.Forms.CheckBox();
            this.chkTV = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdmission
            // 
            this.dgvAdmission.AutoGenerateColumns = false;
            this.dgvAdmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admissionIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.bedNumberDataGridViewTextBoxColumn,
            this.surgeryScheduledDataGridViewCheckBoxColumn,
            this.admissionDateDataGridViewTextBoxColumn,
            this.surgeryDateDataGridViewTextBoxColumn,
            this.dischargeDateDataGridViewTextBoxColumn});
            this.dgvAdmission.DataSource = this.admissionRecordBindingSource;
            this.dgvAdmission.Location = new System.Drawing.Point(12, 12);
            this.dgvAdmission.Name = "dgvAdmission";
            this.dgvAdmission.Size = new System.Drawing.Size(722, 297);
            this.dgvAdmission.TabIndex = 0;
            this.dgvAdmission.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // admissionIDDataGridViewTextBoxColumn
            // 
            this.admissionIDDataGridViewTextBoxColumn.DataPropertyName = "AdmissionID";
            this.admissionIDDataGridViewTextBoxColumn.HeaderText = "AdmissionID";
            this.admissionIDDataGridViewTextBoxColumn.Name = "admissionIDDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // bedNumberDataGridViewTextBoxColumn
            // 
            this.bedNumberDataGridViewTextBoxColumn.DataPropertyName = "BedNumber";
            this.bedNumberDataGridViewTextBoxColumn.HeaderText = "BedNumber";
            this.bedNumberDataGridViewTextBoxColumn.Name = "bedNumberDataGridViewTextBoxColumn";
            // 
            // surgeryScheduledDataGridViewCheckBoxColumn
            // 
            this.surgeryScheduledDataGridViewCheckBoxColumn.DataPropertyName = "SurgeryScheduled";
            this.surgeryScheduledDataGridViewCheckBoxColumn.HeaderText = "SurgeryScheduled";
            this.surgeryScheduledDataGridViewCheckBoxColumn.Name = "surgeryScheduledDataGridViewCheckBoxColumn";
            // 
            // admissionDateDataGridViewTextBoxColumn
            // 
            this.admissionDateDataGridViewTextBoxColumn.DataPropertyName = "AdmissionDate";
            this.admissionDateDataGridViewTextBoxColumn.HeaderText = "AdmissionDate";
            this.admissionDateDataGridViewTextBoxColumn.Name = "admissionDateDataGridViewTextBoxColumn";
            // 
            // surgeryDateDataGridViewTextBoxColumn
            // 
            this.surgeryDateDataGridViewTextBoxColumn.DataPropertyName = "SurgeryDate";
            this.surgeryDateDataGridViewTextBoxColumn.HeaderText = "SurgeryDate";
            this.surgeryDateDataGridViewTextBoxColumn.Name = "surgeryDateDataGridViewTextBoxColumn";
            // 
            // dischargeDateDataGridViewTextBoxColumn
            // 
            this.dischargeDateDataGridViewTextBoxColumn.DataPropertyName = "DischargeDate";
            this.dischargeDateDataGridViewTextBoxColumn.HeaderText = "DischargeDate";
            this.dischargeDateDataGridViewTextBoxColumn.Name = "dischargeDateDataGridViewTextBoxColumn";
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
            // admissionRecordTableAdapter
            // 
            this.admissionRecordTableAdapter.ClearBeforeFill = true;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(109, 368);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(122, 20);
            this.txtPatientID.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Health Number";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(109, 394);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker3.TabIndex = 57;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(109, 420);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker2.TabIndex = 56;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 445);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 55;
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
            this.cboBed.Location = new System.Drawing.Point(109, 471);
            this.cboBed.Name = "cboBed";
            this.cboBed.Size = new System.Drawing.Size(100, 21);
            this.cboBed.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chkSurScheduled);
            this.panel2.Location = new System.Drawing.Point(292, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 43);
            this.panel2.TabIndex = 53;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Bed #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Release Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Surgery Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Admission Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Admission ID";
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Location = new System.Drawing.Point(109, 342);
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.ReadOnly = true;
            this.txtAdmissionID.Size = new System.Drawing.Size(122, 20);
            this.txtAdmissionID.TabIndex = 47;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.chkPhone);
            this.panel4.Controls.Add(this.chkTV);
            this.panel4.Location = new System.Drawing.Point(292, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 91);
            this.panel4.TabIndex = 60;
            // 
            // chkPhone
            // 
            this.chkPhone.AutoSize = true;
            this.chkPhone.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.admissionRecordBindingSource, "SurgeryScheduled", true));
            this.chkPhone.Location = new System.Drawing.Point(18, 23);
            this.chkPhone.Name = "chkPhone";
            this.chkPhone.Size = new System.Drawing.Size(57, 17);
            this.chkPhone.TabIndex = 15;
            this.chkPhone.Text = "Phone";
            this.chkPhone.UseVisualStyleBackColor = true;
            // 
            // chkTV
            // 
            this.chkTV.AutoSize = true;
            this.chkTV.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.admissionRecordBindingSource, "SurgeryScheduled", true));
            this.chkTV.Location = new System.Drawing.Point(18, 50);
            this.chkTV.Name = "chkTV";
            this.chkTV.Size = new System.Drawing.Size(40, 17);
            this.chkTV.TabIndex = 14;
            this.chkTV.Text = "TV";
            this.chkTV.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(400, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(746, 549);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel4);
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
            this.Controls.Add(this.txtAdmissionID);
            this.Controls.Add(this.dgvAdmission);
            this.Name = "btnQuit";
            this.Text = "frmAdmission";
            this.Load += new System.EventHandler(this.frmAdmission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmission;
        private DSPatients dSPatients;
        private System.Windows.Forms.BindingSource admissionRecordBindingSource;
        private NewNLHospital.DSPatientsTableAdapters.AdmissionRecordTableAdapter admissionRecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn surgeryScheduledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surgeryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dischargeDateDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.TextBox txtAdmissionID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.CheckBox chkTV;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
    }
}