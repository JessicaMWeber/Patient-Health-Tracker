using Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medication_Tracker
{
    public partial class VitalSignsForm : Form
    {
        DataConnection data;
        public decimal Temp { get; set; }
        public int BloodPressureTop { get; set; }
        public int BloodPressureBottom { get; set; }
        public int Pulse { get; set; }
        public byte Oxygen { get; set; }
        public byte Respiration { get; set; }
        public int PatientID { get; set; }

        public VitalSignsForm(int patientID)
        {
            PatientID = patientID;
            data = new DataConnection();
            InitializeComponent();
        }


        

        private void AddVitalSignsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void saveVitalSignsToDB()
        {
            ArrayList param = new ArrayList()
                {
                    new SqlParameter("@patientID", PatientID),
                    new SqlParameter("@pulse",  Pulse),
                    new SqlParameter("@bpt",  BloodPressureTop),
                    new SqlParameter("@bpb",  BloodPressureBottom),
                    new SqlParameter("@oxygen",  Oxygen),
                    new SqlParameter("@resp",  Respiration),
                    new SqlParameter("@temp",  Temp)
                };
            data.GetDataSet("SaveVitalSigns", param);
           
        }
        private void BtnSaveVitalSigns_Click(object sender, EventArgs e)
        {

            if (txtTemp == null && txtTemp.Text == string.Empty)
            {
                return;
            }
            else
            {
                Temp = decimal.Parse(txtTemp.Text);
               
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
            

            saveVitalSignsToDB();
            DialogResult = DialogResult.OK;
                   
        }
    }
}
