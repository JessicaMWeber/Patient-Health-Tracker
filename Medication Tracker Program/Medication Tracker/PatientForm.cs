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
    public partial class PatientForm : Form
    {
        public string PatientName { get; set; }
        public DateTime DOB { get; set; }
        public int RoomNumber { get; set; }
        public string Allergies { get; set; }
        public string CodeStatus { get; set; }
        public int ID { get; set; }

        DataConnection data;

        public PatientForm()
        {
            InitializeComponent();
            data = new DataConnection();
        }


        private int savePatient()
        {
            ArrayList param = new ArrayList()
            {
                new SqlParameter("@name", cmbPatient.Text),
                    new SqlParameter("@bday", dtpPatientDOB.Value),
                    new SqlParameter("@room", int.Parse(txtRoomNumber.Text)),
                    new SqlParameter("@allergies", txtAllergies.Text),
                    new SqlParameter("@codestatus", txtCodeStatus.Text),
                    new SqlParameter("@pulse",  Convert.ToInt32(0)),
                    new SqlParameter("@bpt",  Convert.ToInt32(0)),
                    new SqlParameter("@bpb",  Convert.ToInt32(0)),
                    new SqlParameter("@oxygen",  Convert.ToInt32(0)),
                    new SqlParameter("@resp",  Convert.ToInt32(0)),
                    new SqlParameter("@temp", 1.1)
                };
            DataSet ds = data.GetDataSet("InsertPatient", param);
            return (int) ds.Tables[0].Rows[0]["ID"];
         }

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            ID = savePatient();
            PatientName = cmbPatient.Text;
            DOB = dtpPatientDOB.Value;
            RoomNumber = int.Parse(txtRoomNumber.Text);
            Allergies = txtAllergies.Text;
            CodeStatus = txtCodeStatus.Text;
           
            DialogResult = DialogResult.OK;
        }

        private void CmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
