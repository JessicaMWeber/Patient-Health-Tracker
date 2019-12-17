using Data;
using System;
using System.Collections.Generic;
using System.Data;

namespace Medication_Tracker
{
    class Patient : dbObject
    {
        public Patient(int id)
        {
            ID = id;
            LoadObject();
        }

        private void LoadObject()
        {
            BaseTable = "Patient";
            Load();
            DataRow = DataSet.Tables[0].Rows[0];
        }

        public int Pulse
        {
            get
            {
                if (DataRow["Pulse"] == DBNull.Value)
                    return 0;
                return Convert.ToInt32(DataRow["Pulse"]);
            }
            set
            {
                DataRow["Pulse"] = value;
            }
        }
        public int BloodPressureTop
        {
            get
            {
                if (DataRow["BloodPressureTop"] == DBNull.Value)
                    return 0;
                return Convert.ToInt32(DataRow["BloodPressureTop"]);
            }
            set
            {
                DataRow["BloodPressureTop"] = value;
            }
        }
        public int BloodPressureBottom
        {
            get
            {
                if (DataRow["BloodPressureBottom"] == DBNull.Value)
                    return 0;
                return Convert.ToInt32(DataRow["BloodPressureBottom"]);
            }
            set
            {
                DataRow["BloodPressureBottom"] = value;
            }
        }
        public int Oxygen
        {
            get
            {
                if (DataRow["Oxygen"] == DBNull.Value)
                    return 0;
                return Convert.ToInt32(DataRow["Oxygen"]);
            }
            set
            {
                DataRow["Oxygen"] = value;
            }
        }
        public int Respiration
        {
            get
            {
                if (DataRow["Respiration"] == DBNull.Value)
                    return 0;
                return Convert.ToInt32(DataRow["Respiration"]);
            }
            set
            {
                DataRow["Respiration"] = value;
            }
        }
        public decimal Temp
        {
            get
            {
                if (DataRow["Temp"] == DBNull.Value)
                    return 0;
                return Convert.ToDecimal(DataRow["Temp"]);
            }
            set
            {
                DataRow["Temp"] = value;
            }
        }

        public string PatientName
        {
            get
            {
                return DataRow["PatientName"].ToString();
            }
            set
            {
                DataRow["PatientName"] = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return Convert.ToDateTime(DataRow["DateOfBirth"]);
            }
            set
            {
                DataRow["DateOfBirth"] = value;
            }
        }
        public int Room
        {
            get
            {
                return Convert.ToInt32(DataRow["Room"]);
            }
            set
            {
                DataRow["Room"] = value;
            }
        }
        public string Allergies
        {
            get
            {
                return DataRow["Allergies"].ToString();
            }
            set
            {
                DataRow["Allergies"] = value;
            }
        }
        public string CodeStatus
        {
            get
            {
                return DataRow["CodeStatus"].ToString();
            }
            set
            {
                DataRow["CodeStatus"] = value;
            }
        }

        public List<Meds> Medications { get; set; } = new List<Meds>();
    }
}
