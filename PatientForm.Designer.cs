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
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.txtCodeStatus = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.dtpPatientDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(9, 19);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(107, 31);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "Patient:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(9, 67);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(81, 31);
            this.lblDOB.TabIndex = 17;
            this.lblDOB.Text = "DOB:";
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergies.Location = new System.Drawing.Point(9, 162);
            this.lblAllergies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(126, 31);
            this.lblAllergies.TabIndex = 18;
            this.lblAllergies.Text = "Allergies:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Code Status:";
            // 
            // txtAllergies
            // 
            this.txtAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergies.Location = new System.Drawing.Point(129, 157);
            this.txtAllergies.Margin = new System.Windows.Forms.Padding(2);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(314, 37);
            this.txtAllergies.TabIndex = 22;
            // 
            // txtCodeStatus
            // 
            this.txtCodeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeStatus.Location = new System.Drawing.Point(173, 214);
            this.txtCodeStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodeStatus.Name = "txtCodeStatus";
            this.txtCodeStatus.Size = new System.Drawing.Size(270, 37);
            this.txtCodeStatus.TabIndex = 23;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(9, 114);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(94, 31);
            this.lblRoomNumber.TabIndex = 22;
            this.lblRoomNumber.Text = "Room:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(129, 109);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(314, 37);
            this.txtRoomNumber.TabIndex = 21;
            // 
            // dtpPatientDOB
            // 
            this.dtpPatientDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPatientDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPatientDOB.Location = new System.Drawing.Point(129, 62);
            this.dtpPatientDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPatientDOB.Name = "dtpPatientDOB";
            this.dtpPatientDOB.Size = new System.Drawing.Size(314, 37);
            this.dtpPatientDOB.TabIndex = 20;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddPatient.Location = new System.Drawing.Point(129, 288);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(167, 43);
            this.btnAddPatient.TabIndex = 25;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.BtnAddPatient_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(129, 16);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(314, 37);
            this.txtName.TabIndex = 26;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(462, 341);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.dtpPatientDOB);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.txtCodeStatus);
            this.Controls.Add(this.txtAllergies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAllergies);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblPatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientForm";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.TextBox txtCodeStatus;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.DateTimePicker dtpPatientDOB;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.TextBox txtName;
    }
}