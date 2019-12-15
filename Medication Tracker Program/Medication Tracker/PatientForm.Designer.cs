namespace Medication_Tracker
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.lblPatient = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.txtCodeStatus = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.dtpPatientDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(12, 23);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(127, 38);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "Patient:";
            // 
            // cmbPatient
            // 
            this.cmbPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(172, 18);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(418, 44);
            this.cmbPatient.TabIndex = 15;
            this.cmbPatient.SelectedIndexChanged += new System.EventHandler(this.CmbPatient_SelectedIndexChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(12, 82);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(98, 38);
            this.lblDOB.TabIndex = 17;
            this.lblDOB.Text = "DOB:";
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergies.Location = new System.Drawing.Point(12, 199);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(151, 38);
            this.lblAllergies.TabIndex = 18;
            this.lblAllergies.Text = "Allergies:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Code Status:";
            // 
            // txtAllergies
            // 
            this.txtAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergies.Location = new System.Drawing.Point(172, 193);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(418, 45);
            this.txtAllergies.TabIndex = 22;
            // 
            // txtCodeStatus
            // 
            this.txtCodeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeStatus.Location = new System.Drawing.Point(231, 264);
            this.txtCodeStatus.Name = "txtCodeStatus";
            this.txtCodeStatus.Size = new System.Drawing.Size(359, 45);
            this.txtCodeStatus.TabIndex = 23;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(12, 140);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(113, 38);
            this.lblRoomNumber.TabIndex = 22;
            this.lblRoomNumber.Text = "Room:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(172, 134);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(418, 45);
            this.txtRoomNumber.TabIndex = 21;
            // 
            // dtpPatientDOB
            // 
            this.dtpPatientDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPatientDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPatientDOB.Location = new System.Drawing.Point(172, 76);
            this.dtpPatientDOB.Name = "dtpPatientDOB";
            this.dtpPatientDOB.Size = new System.Drawing.Size(418, 45);
            this.dtpPatientDOB.TabIndex = 20;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddPatient.Location = new System.Drawing.Point(172, 354);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(223, 53);
            this.btnAddPatient.TabIndex = 25;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.BtnAddPatient_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(614, 444);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.dtpPatientDOB);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.txtCodeStatus);
            this.Controls.Add(this.txtAllergies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAllergies);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.lblPatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientForm";
            this.Text = "New Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.TextBox txtCodeStatus;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.DateTimePicker dtpPatientDOB;
        private System.Windows.Forms.Button btnAddPatient;
    }
}