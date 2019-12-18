using System;
using System.Windows.Forms;

namespace Medication_Tracker
{
    public partial class AddMedForm : Form
    {
        #region Properties

        public string MedName { get; set; }
        public string Dose { get; set; }
        public string Route { get; set; }
        public DateTime Time { get; set; }

        #endregion Properties

        #region Constructors

        public AddMedForm(string medName)
        {
            CenterToScreen();

            InitializeComponent();

            MedName = medName;

            lblName.Text = MedName;
        }

        #endregion Constructors

        #region Events

        private void BtnSaveMed_Click(object sender, EventArgs e)
        {
            if(txtDose.Text == "" || txtDose.Text == "")
            {
                return;
            }

            Dose = txtDose.Text;
            Route = txtRoute.Text;
            Time = dtpMedTime.Value;

            DialogResult = DialogResult.OK;
        }

        #endregion Events
    }
}
