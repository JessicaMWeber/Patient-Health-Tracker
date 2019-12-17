using System;
using System.Windows.Forms;

namespace Medication_Tracker
{
    partial class PatientForm : Form
    {
        public Patient Patient { get; set; }

        public PatientForm(Patient patient)
        {
            Patient = patient;

            CenterToScreen();

            InitializeComponent();
        }

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            Patient = new Patient(0)
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
    }
}
