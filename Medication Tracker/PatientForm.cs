using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medication_Tracker
{
    public partial class PatientForm : Form
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int RoomNumber { get; set; }
        public string Allergies { get; set; }
        public string CodeStatus { get; set; }

        public PatientForm()
        {
            InitializeComponent();
        }

      

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            Name = cmbPatient.Text;
            DOB = dtpPatientDOB.Value;
            RoomNumber = int.Parse(txtRoomNumber.Text);
            Allergies = txtAllergies.Text;
            CodeStatus = txtCodeStatus.Text;
           
            DialogResult = DialogResult.OK;
        }
    }
}
