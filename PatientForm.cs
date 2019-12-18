using System;
using System.Drawing;
using System.Windows.Forms;

namespace Medication_Tracker
{
    partial class PatientForm : Form
    {
        #region Properties

        public Patient Patient { get; set; }

        #endregion Properties

        #region Constructors

        public PatientForm(Patient patient)
        {
            Patient = patient;

            CenterToScreen();

            InitializeComponent();
        }

        #endregion Constructors

        #region Events

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            if (!ValidateControls())
                return;

            Patient = new Patient()
            {
                PatientName = txtName.Text,
                DateOfBirth = dtpPatientDOB.Value,
                Room = int.Parse(txtRoomNumber.Text),
                Allergies = txtAllergies.Text,
                CodeStatus = txtCodeStatus.Text
            };
            Patient.Save(insert : true);
           
            DialogResult = DialogResult.OK;
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtName;
        }

        #endregion Events

        #region Helper Methods

        private bool ValidateControls()
        {
            bool valid = true;

            txtName.BackColor = SystemColors.Window;
            txtRoomNumber.BackColor = SystemColors.Window;
            txtAllergies.BackColor = SystemColors.Window;
            txtCodeStatus.BackColor = SystemColors.Window;
            if (txtName.Text == "")
            {
                txtName.BackColor = Color.Red;
                valid = false;
            }
            if (txtRoomNumber.Text == "" || int.TryParse(txtRoomNumber.Text, out _) == false)
            {
                txtRoomNumber.BackColor = Color.Red;
                valid = false;
            }
            if (txtAllergies.Text == "")
            {
                txtAllergies.BackColor = Color.Red;
                valid = false;
            }
            if(txtCodeStatus.Text == "")
            {
                txtCodeStatus.BackColor = Color.Red;
                valid = false;
            }
            return valid;
        }

        #endregion Helper Methods
    }
}
