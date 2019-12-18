using Data;
using System;

namespace Medication_Tracker
{
    public class MedsTakenHistory : DataObject
    {
        #region Constructors

        public MedsTakenHistory()
        {
            ID = 0;
            LoadObject();
        }

        public MedsTakenHistory(int id)
        {
            ID = id;
            LoadObject();
        }

        #endregion Constructors

        #region Helper Methods

        private void LoadObject()
        {
            BaseTable = "MedsTakenHistory";
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

        public int MedID
        {
            get
            {
                return Convert.ToInt32(DataRow["MedID"]);
            }
            set
            {
                DataRow["MedID"] = value;
            }
        }

        public DateTime TimeTaken
        {
            get
            {
                return Convert.ToDateTime(DataRow["TimeTaken"]);
            }
            set
            {
                DataRow["TimeTaken"] = value;
            }
        }

        #endregion Properties
    }
}
