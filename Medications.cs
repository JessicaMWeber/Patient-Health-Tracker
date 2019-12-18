using Data;
using System;

namespace Medication_Tracker
{
    public class Medications : DataObject
    {
        #region Constructors

        public Medications()
        {
            ID = 0;
            LoadObject();
        }

        public Medications(int id)
        {
            ID = id;
            LoadObject();
        }

        #endregion Constructors

        #region Helper Methods

        private void LoadObject()
        {
            BaseTable = "Medications";
            Load();
            DataRow = DataSet.Tables[0].Rows[0];
        }

        #endregion Helper Methods

        #region Properties

        public int PatientID
        {
            get
            {
                return Convert.ToInt32(DataRow["PatientID"]);
            }
            set
            {
                DataRow["PatientID"] = value;
            }
        }

        public string MedName
        {
            get
            {
                return DataRow["MedName"].ToString();
            }
            set
            {
                DataRow["MedName"] = value;
            }
        }

        public string Symptom
        {
            get
            {
                return DataRow["Symptom"].ToString();
            }
            set
            {
                DataRow["Symptom"] = value;
            }
        }

        public string Dose
        {
            get
            {
                return DataRow["Dose"].ToString();
            }
            set
            {
                DataRow["Dose"] = value;
            }
        }

        public string Route
        {
            get
            {
                return DataRow["Route"].ToString();
            }
            set
            {
                DataRow["Route"] = value;
            }
        }

        public DateTime MedTime
        {
            get
            {
                if(DataRow["MedTime"] == DBNull.Value)
                {
                    return DateTime.MinValue;
                }
                return Convert.ToDateTime(DataRow["MedTime"]);
            }
            set
            {
                DataRow["MedTime"] = value;
            }
        }

        #endregion Properties
    }
}
