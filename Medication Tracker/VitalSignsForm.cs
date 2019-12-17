using Data;
using System;
using System.Windows.Forms;

namespace Medication_Tracker
{
    partial class VitalSignsForm : Form
    {
        DataConnection data;

        public Patient Patient { get; set; }

        public VitalSignsForm(Patient patient)
        {
            CenterToScreen();
            Patient = patient;
            data = new DataConnection();
            InitializeComponent();
        }

        private void BtnSaveVitalSigns_Click(object sender, EventArgs e)
        {

            if (txtTemp == null && txtTemp.Text == string.Empty)
            {
                return;
            }
            else
            {
                Patient.Temp = decimal.Parse(txtTemp.Text);
               
            }
            if (txtPulse == null && txtPulse.Text == string.Empty)
            {
                return;
            }
            else
            {
                Patient.Pulse = int.Parse(txtPulse.Text);

            }
            if (txtOxygen == null && txtOxygen.Text == string.Empty)
            {
                return;
            }
            else
            {
                Patient.Oxygen = byte.Parse(txtOxygen.Text); 

            }
            if (txtRespirations == null && txtRespirations.Text == string.Empty)
            {
                return;
            }
            else
            {
                Patient.Respiration = byte.Parse(txtRespirations.Text);

            }
            if (txtBP_Top == null && txtBP_Top.Text == string.Empty)
            {
                return;
            }
            else
            {
                Patient.BloodPressureTop = int.Parse(txtBP_Top.Text);

            }
            if (txtBP_Bottom == null && txtBP_Bottom.Text == string.Empty)
            {
                return;
            }
            else
            {
                Patient.BloodPressureBottom = int.Parse(txtBP_Bottom.Text);

            }

            Patient.Save(insert : false);

            DialogResult = DialogResult.OK;
                   
        }
    }
}
