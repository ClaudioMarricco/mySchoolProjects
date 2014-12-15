namespace NewNLHospital
{
    partial class frmDischarge
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
            this.btnDischarge = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtHealthNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDischarge
            // 
            this.btnDischarge.Location = new System.Drawing.Point(56, 251);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(75, 23);
            this.btnDischarge.TabIndex = 0;
            this.btnDischarge.Text = "Discharge";
            this.btnDischarge.UseVisualStyleBackColor = true;
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtHealthNumber
            // 
            this.txtHealthNumber.Location = new System.Drawing.Point(56, 52);
            this.txtHealthNumber.Name = "txtHealthNumber";
            this.txtHealthNumber.ReadOnly = true;
            this.txtHealthNumber.Size = new System.Drawing.Size(195, 20);
            this.txtHealthNumber.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(56, 90);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(195, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(56, 129);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(195, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Health Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current Ward";
            // 
            // txtWard
            // 
            this.txtWard.Location = new System.Drawing.Point(56, 172);
            this.txtWard.Name = "txtWard";
            this.txtWard.ReadOnly = true;
            this.txtWard.Size = new System.Drawing.Size(195, 20);
            this.txtWard.TabIndex = 8;
            // 
            // frmDischarge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(330, 315);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtHealthNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDischarge);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmDischarge";
            this.Text = "Discharge Patient";
            this.Load += new System.EventHandler(this.frmDischarge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtHealthNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWard;
    }
}