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
    public partial class VitalSignsForm : Form
    {
        public double Temp { get; set; }
        public int BloodPressureTop { get; set; }
        public int BloodPressureBottom { get; set; }
        public int Pulse { get; set; }
        public byte Oxygen { get; set; }
        public byte Respiration { get; set; }

        public VitalSignsForm()
        {
            InitializeComponent();
        }


        

        private void AddVitalSignsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnSaveVitalSigns_Click(object sender, EventArgs e)
        {
                               
            if (txtTemp == null && txtTemp.Text == string.Empty)
            {
                return;
            }
            else
            {
                Temp = double.Parse(txtTemp.Text);
               
            }
            if (txtPulse == null && txtPulse.Text == string.Empty)
            {
                return;
            }
            else
            {
                Pulse = int.Parse(txtPulse.Text);

            }
            if (txtOxygen == null && txtOxygen.Text == string.Empty)
            {
                return;
            }
            else
            {
                Oxygen = byte.Parse(txtOxygen.Text); 

            }
            if (txtRespirations == null && txtRespirations.Text == string.Empty)
            {
                return;
            }
            else
            {
                Respiration = byte.Parse(txtRespirations.Text);

            }
            if (txtBP_Top == null && txtBP_Top.Text == string.Empty)
            {
                return;
            }
            else
            {
                BloodPressureTop = int.Parse(txtBP_Top.Text);

            }
            if (txtBP_Bottom == null && txtBP_Bottom.Text == string.Empty)
            {
                return;
            }
            else
            {
                BloodPressureBottom = int.Parse(txtBP_Bottom.Text);

            }

            DialogResult = DialogResult.OK;
                   
        }
    }
}
