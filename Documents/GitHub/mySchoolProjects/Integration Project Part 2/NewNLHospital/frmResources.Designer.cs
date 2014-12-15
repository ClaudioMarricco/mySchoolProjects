namespace NewNLHospital
{
    partial class frmResources
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
            this.dgvResources = new System.Windows.Forms.DataGridView();
            this.bedNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPatients = new NewNLHospital.DSPatients();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWardName = new System.Windows.Forms.TextBox();
            this.txtBedType = new System.Windows.Forms.TextBox();
            this.txtBedNumber = new System.Windows.Forms.TextBox();
            this.chkOccupied = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.bedsTableAdapter = new NewNLHospital.DSPatientsTableAdapters.BedsTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResources
            // 
            this.dgvResources.AutoGenerateColumns = false;
            this.dgvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bedNumberDataGridViewTextBoxColumn,
            this.Occupied,
            this.bedTypeDataGridViewTextBoxColumn,
            this.wardNameDataGridViewTextBoxColumn});
            this.dgvResources.DataSource = this.bedsBindingSource;
            this.dgvResources.Location = new System.Drawing.Point(12, 12);
            this.dgvResources.Name = "dgvResources";
            this.dgvResources.Size = new System.Drawing.Size(422, 278);
            this.dgvResources.TabIndex = 0;
            // 
            // bedNumberDataGridViewTextBoxColumn
            // 
            this.bedNumberDataGridViewTextBoxColumn.DataPropertyName = "BedNumber";
            this.bedNumberDataGridViewTextBoxColumn.HeaderText = "BedNumber";
            this.bedNumberDataGridViewTextBoxColumn.Name = "bedNumberDataGridViewTextBoxColumn";
            // 
            // Occupied
            // 
            this.Occupied.DataPropertyName = "Occupied";
            this.Occupied.HeaderText = "Occupied";
            this.Occupied.Name = "Occupied";
            this.Occupied.Width = 75;
            // 
            // bedTypeDataGridViewTextBoxColumn
            // 
            this.bedTypeDataGridViewTextBoxColumn.DataPropertyName = "BedType";
            this.bedTypeDataGridViewTextBoxColumn.HeaderText = "BedType";
            this.bedTypeDataGridViewTextBoxColumn.Name = "bedTypeDataGridViewTextBoxColumn";
            // 
            // wardNameDataGridViewTextBoxColumn
            // 
            this.wardNameDataGridViewTextBoxColumn.DataPropertyName = "WardName";
            this.wardNameDataGridViewTextBoxColumn.HeaderText = "WardName";
            this.wardNameDataGridViewTextBoxColumn.Name = "wardNameDataGridViewTextBoxColumn";
            // 
            // bedsBindingSource
            // 
            this.bedsBindingSource.DataMember = "Beds";
            this.bedsBindingSource.DataSource = this.dSPatients;
            // 
            // dSPatients
            // 
            this.dSPatients.DataSetName = "DSPatients";
            this.dSPatients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtWardName);
            this.panel1.Controls.Add(this.txtBedType);
            this.panel1.Controls.Add(this.txtBedNumber);
            this.panel1.Controls.Add(this.chkOccupied);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(12, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 172);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ward Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bed Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bed Number";
            // 
            // txtWardName
            // 
            this.txtWardName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedsBindingSource, "WardName", true));
            this.txtWardName.Location = new System.Drawing.Point(6, 105);
            this.txtWardName.Name = "txtWardName";
            this.txtWardName.ReadOnly = true;
            this.txtWardName.Size = new System.Drawing.Size(135, 20);
            this.txtWardName.TabIndex = 7;
            // 
            // txtBedType
            // 
            this.txtBedType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedsBindingSource, "BedType", true));
            this.txtBedType.Location = new System.Drawing.Point(6, 66);
            this.txtBedType.Name = "txtBedType";
            this.txtBedType.ReadOnly = true;
            this.txtBedType.Size = new System.Drawing.Size(135, 20);
            this.txtBedType.TabIndex = 6;
            // 
            // txtBedNumber
            // 
            this.txtBedNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedsBindingSource, "BedNumber", true));
            this.txtBedNumber.Location = new System.Drawing.Point(6, 27);
            this.txtBedNumber.Name = "txtBedNumber";
            this.txtBedNumber.ReadOnly = true;
            this.txtBedNumber.Size = new System.Drawing.Size(135, 20);
            this.txtBedNumber.TabIndex = 5;
            // 
            // chkOccupied
            // 
            this.chkOccupied.AutoSize = true;
            this.chkOccupied.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bedsBindingSource, "Occupied", true));
            this.chkOccupied.Location = new System.Drawing.Point(195, 30);
            this.chkOccupied.Name = "chkOccupied";
            this.chkOccupied.Size = new System.Drawing.Size(72, 17);
            this.chkOccupied.TabIndex = 4;
            this.chkOccupied.Text = "Occupied";
            this.chkOccupied.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(192, 102);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bedsTableAdapter
            // 
            this.bedsTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(364, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(446, 479);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvResources);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmResources";
            this.Text = "Resources";
            this.Load += new System.EventHandler(this.frmResources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPatients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResources;
        private System.Windows.Forms.Panel panel1;
        private DSPatients dSPatients;
        private System.Windows.Forms.BindingSource bedsBindingSource;
        private NewNLHospital.DSPatientsTableAdapters.BedsTableAdapter bedsTableAdapter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWardName;
        private System.Windows.Forms.TextBox txtBedType;
        private System.Windows.Forms.TextBox txtBedNumber;
        private System.Windows.Forms.CheckBox chkOccupied;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupied;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wardNameDataGridViewTextBoxColumn;
    }
}