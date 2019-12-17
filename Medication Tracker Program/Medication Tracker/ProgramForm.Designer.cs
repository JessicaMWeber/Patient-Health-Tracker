namespace Medication_Tracker
{
    partial class ProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramForm));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnDueNow = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.pnlInit = new System.Windows.Forms.Panel();
            this.lblMed_Symptom = new System.Windows.Forms.Label();
            this.lblMed_Dose_Route = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMedName = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.btnAddVitalSigns = new System.Windows.Forms.Button();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblCodeStatus = new System.Windows.Forms.Label();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblDOB_Display = new System.Windows.Forms.Label();
            this.lblRoomNumber_Display = new System.Windows.Forms.Label();
            this.lblAllergies_Display = new System.Windows.Forms.Label();
            this.lblCodeStatus_Display = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMedicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBPT_Display = new System.Windows.Forms.Label();
            this.lblR_Display = new System.Windows.Forms.Label();
            this.lblP_Display = new System.Windows.Forms.Label();
            this.lblT_Display = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblBP = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblVitalSigns_Text = new System.Windows.Forms.Label();
            this.lblBPB_Display = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblO2_Display = new System.Windows.Forms.Label();
            this.lblO2 = new System.Windows.Forms.Label();
            this.lblCurrentTime_Display = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMeds = new System.Windows.Forms.Panel();
            this.pnlInit.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlMeds.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(968, 99);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);
            // 
            // btnDueNow
            // 
            this.btnDueNow.BackColor = System.Drawing.Color.White;
            this.btnDueNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDueNow.Location = new System.Drawing.Point(12, 255);
            this.btnDueNow.Margin = new System.Windows.Forms.Padding(2);
            this.btnDueNow.Name = "btnDueNow";
            this.btnDueNow.Size = new System.Drawing.Size(174, 46);
            this.btnDueNow.TabIndex = 2;
            this.btnDueNow.Text = "Due Now";
            this.btnDueNow.UseVisualStyleBackColor = false;
            this.btnDueNow.Click += new System.EventHandler(this.DueNow_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.White;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewAll.Location = new System.Drawing.Point(191, 258);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(160, 44);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.BtnViewAll_Click);
            // 
            // pnlInit
            // 
            this.pnlInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlInit.Controls.Add(this.lblMed_Symptom);
            this.pnlInit.Controls.Add(this.lblMed_Dose_Route);
            this.pnlInit.Controls.Add(this.btnNo);
            this.pnlInit.Controls.Add(this.btnYes);
            this.pnlInit.Controls.Add(this.lblTime);
            this.pnlInit.Controls.Add(this.lblMedName);
            this.pnlInit.Location = new System.Drawing.Point(2, 2);
            this.pnlInit.Margin = new System.Windows.Forms.Padding(2);
            this.pnlInit.Name = "pnlInit";
            this.pnlInit.Size = new System.Drawing.Size(578, 144);
            this.pnlInit.TabIndex = 4;
            // 
            // lblMed_Symptom
            // 
            this.lblMed_Symptom.AutoSize = true;
            this.lblMed_Symptom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed_Symptom.Location = new System.Drawing.Point(110, 106);
            this.lblMed_Symptom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMed_Symptom.Name = "lblMed_Symptom";
            this.lblMed_Symptom.Size = new System.Drawing.Size(72, 24);
            this.lblMed_Symptom.TabIndex = 7;
            this.lblMed_Symptom.Text = "for pain";
            // 
            // lblMed_Dose_Route
            // 
            this.lblMed_Dose_Route.AutoSize = true;
            this.lblMed_Dose_Route.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed_Dose_Route.Location = new System.Drawing.Point(109, 64);
            this.lblMed_Dose_Route.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMed_Dose_Route.Name = "lblMed_Dose_Route";
            this.lblMed_Dose_Route.Size = new System.Drawing.Size(191, 29);
            this.lblMed_Dose_Route.TabIndex = 6;
            this.lblMed_Dose_Route.Text = "500 mg 1 tab PO";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.White;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(510, 42);
            this.btnNo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(54, 51);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "N";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.White;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(450, 42);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(54, 51);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "Y";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(2, 58);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(102, 25);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "12:00 pm";
            // 
            // lblMedName
            // 
            this.lblMedName.AutoSize = true;
            this.lblMedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedName.Location = new System.Drawing.Point(109, 22);
            this.lblMedName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedName.Name = "lblMedName";
            this.lblMedName.Size = new System.Drawing.Size(266, 29);
            this.lblMedName.TabIndex = 0;
            this.lblMedName.Text = "Tylenol Acetaminophen";
            // 
            // cmbPatient
            // 
            this.cmbPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(172, 68);
            this.cmbPatient.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(376, 44);
            this.cmbPatient.TabIndex = 13;
            this.cmbPatient.SelectedIndexChanged += new System.EventHandler(this.CmbPatient_SelectedIndexChanged);
            // 
            // btnAddVitalSigns
            // 
            this.btnAddVitalSigns.BackColor = System.Drawing.Color.White;
            this.btnAddVitalSigns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVitalSigns.Location = new System.Drawing.Point(630, 259);
            this.btnAddVitalSigns.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddVitalSigns.Name = "btnAddVitalSigns";
            this.btnAddVitalSigns.Size = new System.Drawing.Size(159, 42);
            this.btnAddVitalSigns.TabIndex = 14;
            this.btnAddVitalSigns.Text = "Add Vital Signs";
            this.btnAddVitalSigns.UseVisualStyleBackColor = false;
            this.btnAddVitalSigns.Click += new System.EventHandler(this.BtnAddVitalSigns_Click);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(22, 68);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(127, 38);
            this.lblPatient.TabIndex = 15;
            this.lblPatient.Text = "Patient:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(168, 154);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(69, 25);
            this.lblRoomNumber.TabIndex = 26;
            this.lblRoomNumber.Text = "Room:";
            // 
            // lblCodeStatus
            // 
            this.lblCodeStatus.AutoSize = true;
            this.lblCodeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeStatus.Location = new System.Drawing.Point(169, 204);
            this.lblCodeStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodeStatus.Name = "lblCodeStatus";
            this.lblCodeStatus.Size = new System.Drawing.Size(116, 24);
            this.lblCodeStatus.TabIndex = 25;
            this.lblCodeStatus.Text = "Code Status:";
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergies.Location = new System.Drawing.Point(168, 179);
            this.lblAllergies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(93, 25);
            this.lblAllergies.TabIndex = 24;
            this.lblAllergies.Text = "Allergies:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(169, 129);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(55, 24);
            this.lblDOB.TabIndex = 23;
            this.lblDOB.Text = "DOB:";
            // 
            // lblDOB_Display
            // 
            this.lblDOB_Display.AutoSize = true;
            this.lblDOB_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB_Display.Location = new System.Drawing.Point(231, 129);
            this.lblDOB_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB_Display.Name = "lblDOB_Display";
            this.lblDOB_Display.Size = new System.Drawing.Size(80, 24);
            this.lblDOB_Display.TabIndex = 27;
            this.lblDOB_Display.Text = "12/10/96";
            // 
            // lblRoomNumber_Display
            // 
            this.lblRoomNumber_Display.AutoSize = true;
            this.lblRoomNumber_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber_Display.Location = new System.Drawing.Point(242, 156);
            this.lblRoomNumber_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomNumber_Display.Name = "lblRoomNumber_Display";
            this.lblRoomNumber_Display.Size = new System.Drawing.Size(50, 24);
            this.lblRoomNumber_Display.TabIndex = 28;
            this.lblRoomNumber_Display.Text = "0905";
            // 
            // lblAllergies_Display
            // 
            this.lblAllergies_Display.AutoSize = true;
            this.lblAllergies_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergies_Display.Location = new System.Drawing.Point(268, 179);
            this.lblAllergies_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllergies_Display.Name = "lblAllergies_Display";
            this.lblAllergies_Display.Size = new System.Drawing.Size(111, 24);
            this.lblAllergies_Display.TabIndex = 29;
            this.lblAllergies_Display.Text = "Chihuahuas";
            // 
            // lblCodeStatus_Display
            // 
            this.lblCodeStatus_Display.AutoSize = true;
            this.lblCodeStatus_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeStatus_Display.Location = new System.Drawing.Point(291, 204);
            this.lblCodeStatus_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodeStatus_Display.Name = "lblCodeStatus_Display";
            this.lblCodeStatus_Display.Size = new System.Drawing.Size(92, 24);
            this.lblCodeStatus_Display.TabIndex = 30;
            this.lblCodeStatus_Display.Text = "Full Code";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 45);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientToolStripMenuItem,
            this.changeMedicationsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 41);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(298, 42);
            this.addPatientToolStripMenuItem.Text = "New Patient";
            this.addPatientToolStripMenuItem.Click += new System.EventHandler(this.AddPatientToolStripMenuItem_Click);
            // 
            // changeMedicationsToolStripMenuItem
            // 
            this.changeMedicationsToolStripMenuItem.Name = "changeMedicationsToolStripMenuItem";
            this.changeMedicationsToolStripMenuItem.Size = new System.Drawing.Size(298, 42);
            this.changeMedicationsToolStripMenuItem.Text = "Add Medication";
            this.changeMedicationsToolStripMenuItem.Click += new System.EventHandler(this.ChangeMedicationsToolStripMenuItem_Click);
            // 
            // lblBPT_Display
            // 
            this.lblBPT_Display.AutoSize = true;
            this.lblBPT_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPT_Display.Location = new System.Drawing.Point(818, 100);
            this.lblBPT_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBPT_Display.Name = "lblBPT_Display";
            this.lblBPT_Display.Size = new System.Drawing.Size(40, 24);
            this.lblBPT_Display.TabIndex = 39;
            this.lblBPT_Display.Text = "120";
            // 
            // lblR_Display
            // 
            this.lblR_Display.AutoSize = true;
            this.lblR_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR_Display.Location = new System.Drawing.Point(668, 191);
            this.lblR_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblR_Display.Name = "lblR_Display";
            this.lblR_Display.Size = new System.Drawing.Size(30, 24);
            this.lblR_Display.TabIndex = 38;
            this.lblR_Display.Text = "12";
            // 
            // lblP_Display
            // 
            this.lblP_Display.AutoSize = true;
            this.lblP_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP_Display.Location = new System.Drawing.Point(668, 146);
            this.lblP_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP_Display.Name = "lblP_Display";
            this.lblP_Display.Size = new System.Drawing.Size(30, 24);
            this.lblP_Display.TabIndex = 37;
            this.lblP_Display.Text = "68";
            // 
            // lblT_Display
            // 
            this.lblT_Display.AutoSize = true;
            this.lblT_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_Display.Location = new System.Drawing.Point(664, 106);
            this.lblT_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT_Display.Name = "lblT_Display";
            this.lblT_Display.Size = new System.Drawing.Size(45, 24);
            this.lblT_Display.TabIndex = 36;
            this.lblT_Display.Text = "96.8";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(630, 145);
            this.lblP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(31, 25);
            this.lblP.TabIndex = 35;
            this.lblP.Text = "P:";
            // 
            // lblBP
            // 
            this.lblBP.AutoSize = true;
            this.lblBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBP.Location = new System.Drawing.Point(766, 106);
            this.lblBP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(44, 24);
            this.lblBP.TabIndex = 34;
            this.lblBP.Text = "B/P:";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(630, 191);
            this.lblR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(31, 25);
            this.lblR.TabIndex = 33;
            this.lblR.Text = "R:";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(631, 106);
            this.lblT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(27, 24);
            this.lblT.TabIndex = 32;
            this.lblT.Text = "T:";
            // 
            // lblVitalSigns_Text
            // 
            this.lblVitalSigns_Text.AutoSize = true;
            this.lblVitalSigns_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitalSigns_Text.Location = new System.Drawing.Point(626, 68);
            this.lblVitalSigns_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVitalSigns_Text.Name = "lblVitalSigns_Text";
            this.lblVitalSigns_Text.Size = new System.Drawing.Size(108, 24);
            this.lblVitalSigns_Text.TabIndex = 40;
            this.lblVitalSigns_Text.Text = "Vital Signs";
            // 
            // lblBPB_Display
            // 
            this.lblBPB_Display.AutoSize = true;
            this.lblBPB_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPB_Display.Location = new System.Drawing.Point(818, 130);
            this.lblBPB_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBPB_Display.Name = "lblBPB_Display";
            this.lblBPB_Display.Size = new System.Drawing.Size(40, 24);
            this.lblBPB_Display.TabIndex = 41;
            this.lblBPB_Display.Text = "120";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(818, 106);
            this.lblLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(50, 24);
            this.lblLine.TabIndex = 42;
            this.lblLine.Text = "____";
            // 
            // lblO2_Display
            // 
            this.lblO2_Display.AutoSize = true;
            this.lblO2_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO2_Display.Location = new System.Drawing.Point(818, 192);
            this.lblO2_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblO2_Display.Name = "lblO2_Display";
            this.lblO2_Display.Size = new System.Drawing.Size(30, 24);
            this.lblO2_Display.TabIndex = 44;
            this.lblO2_Display.Text = "98";
            // 
            // lblO2
            // 
            this.lblO2.AutoSize = true;
            this.lblO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO2.Location = new System.Drawing.Point(762, 191);
            this.lblO2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblO2.Name = "lblO2";
            this.lblO2.Size = new System.Drawing.Size(45, 25);
            this.lblO2.TabIndex = 43;
            this.lblO2.Text = "O2:";
            // 
            // lblCurrentTime_Display
            // 
            this.lblCurrentTime_Display.AutoSize = true;
            this.lblCurrentTime_Display.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime_Display.Location = new System.Drawing.Point(964, 70);
            this.lblCurrentTime_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentTime_Display.Name = "lblCurrentTime_Display";
            this.lblCurrentTime_Display.Size = new System.Drawing.Size(97, 22);
            this.lblCurrentTime_Display.TabIndex = 45;
            this.lblCurrentTime_Display.Text = "Date Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pnlMeds
            // 
            this.pnlMeds.AutoScroll = true;
            this.pnlMeds.AutoSize = true;
            this.pnlMeds.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMeds.Controls.Add(this.pnlInit);
            this.pnlMeds.Location = new System.Drawing.Point(14, 312);
            this.pnlMeds.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMeds.MaximumSize = new System.Drawing.Size(1250, 550);
            this.pnlMeds.MinimumSize = new System.Drawing.Size(1188, 150);
            this.pnlMeds.Name = "pnlMeds";
            this.pnlMeds.Size = new System.Drawing.Size(1188, 150);
            this.pnlMeds.TabIndex = 46;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1275, 497);
            this.Controls.Add(this.pnlMeds);
            this.Controls.Add(this.lblCurrentTime_Display);
            this.Controls.Add(this.lblBPB_Display);
            this.Controls.Add(this.lblO2_Display);
            this.Controls.Add(this.lblO2);
            this.Controls.Add(this.lblVitalSigns_Text);
            this.Controls.Add(this.lblBPT_Display);
            this.Controls.Add(this.lblR_Display);
            this.Controls.Add(this.lblP_Display);
            this.Controls.Add(this.lblT_Display);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblBP);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblCodeStatus_Display);
            this.Controls.Add(this.lblAllergies_Display);
            this.Controls.Add(this.lblRoomNumber_Display);
            this.Controls.Add(this.lblDOB_Display);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblCodeStatus);
            this.Controls.Add(this.lblAllergies);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.btnAddVitalSigns);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnDueNow);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProgramForm";
            this.Text = "Medication Tracker";
            this.pnlInit.ResumeLayout(false);
            this.pnlInit.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMeds.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnDueNow;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Panel pnlInit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMedName;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Button btnAddVitalSigns;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblCodeStatus;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblDOB_Display;
        private System.Windows.Forms.Label lblRoomNumber_Display;
        private System.Windows.Forms.Label lblAllergies_Display;
        private System.Windows.Forms.Label lblCodeStatus_Display;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMedicationsToolStripMenuItem;
        private System.Windows.Forms.Label lblBPT_Display;
        private System.Windows.Forms.Label lblR_Display;
        private System.Windows.Forms.Label lblP_Display;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblVitalSigns_Text;
        private System.Windows.Forms.Label lblBPB_Display;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblO2_Display;
        private System.Windows.Forms.Label lblO2;
        public System.Windows.Forms.Label lblT_Display;
        private System.Windows.Forms.Label lblMed_Dose_Route;
        private System.Windows.Forms.Label lblMed_Symptom;
        private System.Windows.Forms.Label lblCurrentTime_Display;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlMeds;
    }
}

