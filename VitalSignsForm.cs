using System;
using System.Drawing;
using System.Windows.Forms;

namespace Medication_Tracker
{
    partial class VitalSignsForm : Form
    {
        #region Properties

        public Patient Patient { get; set; }

        #endregion Properties

        #region Constructors

        public VitalSignsForm(Patient patient)
        {
            CenterToScreen();
            Patient = patient;
            InitializeComponent();
        }

        #endregion Constructors

        #region Events

        private void BtnSaveVitalSigns_Click(object sender, EventArgs e)
        {
            if (!ValidateControls())
            {
                return;
            }

            Patient.Temp = decimal.Parse(txtTemp.Text);
            Patient.Pulse = int.Parse(txtPulse.Text);
            Patient.Oxygen = int.Parse(txtOxygen.Text);
            Patient.Respiration = int.Parse(txtRespirations.Text);
            Patient.BloodPressureTop = int.Parse(txtBP_Top.Text);
            Patient.BloodPressureBottom = int.Parse(txtBP_Bottom.Text);
            Patient.Save(insert : false);

            DialogResult = DialogResult.OK;                   
        }

        #endregion Events

        #region Helper Methods

        private bool ValidateControls()
        {
            bool valid = true;

            txtTemp.BackColor = SystemColors.Window;
            txtPulse.BackColor = SystemColors.Window;
            txtOxygen.BackColor = SystemColors.Window;
            txtRespirations.BackColor = SystemColors.Window;
            txtBP_Top.BackColor = SystemColors.Window;
            txtBP_Bottom.BackColor = SystemColors.Window;

            if (txtTemp.Text == "" || decimal.TryParse(txtTemp.Text, out _) == false)
            {
                txtTemp.BackColor = Color.Red;
                valid = false;
            }
            if (txtPulse.Text == "" || int.TryParse(txtPulse.Text, out _) == false)
            {
                txtPulse.BackColor = Color.Red;
                valid = false;
            }
            if (txtOxygen.Text == "" || int.TryParse(txtOxygen.Text, out _) == false)
            {
                txtOxygen.BackColor = Color.Red;
                valid = false;
            }
            if (txtRespirations.Text == "" || int.TryParse(txtRespirations.Text, out _) == false)
            {
                txtRespirations.BackColor = Color.Red;
                valid = false;
            }
            if (txtBP_Top.Text == "" || int.TryParse(txtBP_Top.Text, out _) == false)
            {
                txtBP_Top.BackColor = Color.Red;
                valid = false;
            }
            if (txtBP_Bottom.Text == "" || int.TryParse(txtBP_Bottom.Text, out _) == false)
            {
                txtBP_Bottom.BackColor = Color.Red;
                valid = false;
            }

            return valid;
        }

        #endregion Helper Methods
    }
}
