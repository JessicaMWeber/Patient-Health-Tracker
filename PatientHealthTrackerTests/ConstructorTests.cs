using Microsoft.VisualStudio.TestTools.UnitTesting;
using Medication_Tracker;
using Data;
using System.Data;

namespace PatientHealthTrackerTests
{
    [TestClass]
    public class ConstructorTests
    {
        private DataConnection data;
        private int medsID = -1;
        private int patientID = -1;
        private int medHist = -1;

        [TestMethod]
        public void PatientTestNoParameters()
        {
            _ = new Patient();
        }

        [TestMethod]
        public void PatientTestWithParameter()
        {
            if(patientID > -1)
                _ = new Patient(patientID);
        }

        [TestMethod]
        public void MedicationTestNoParameters()
        {
            _ = new Medications();
        }

        [TestMethod]
        public void MedicationTestWithParameter()
        {
            if (medsID > -1)
                _ = new Medications(medsID);
        }

        [TestMethod]
        public void MedsTakenNoParameters()
        {
            _ = new MedsTakenHistory();
        }

        [TestMethod]
        public void MedsTakenWithWithParameter()
        {
            if (medHist > -1)
                _ = new MedsTakenHistory(medHist);
        }

        [TestMethod]
        public void PatientProperties()
        {
            if (patientID > -1)
            {
                Patient p = new Patient(patientID);
                p.ID = p.ID;
                p.Pulse = p.Pulse;
                p.BloodPressureTop = p.BloodPressureTop;
                p.BloodPressureBottom = p.BloodPressureBottom;
                p.Oxygen = p.Oxygen;
                p.Respiration = p.Respiration;
                p.Temp = p.Temp;
                p.PatientName = p.PatientName;
                p.DateOfBirth = p.DateOfBirth;
                p.Room = p.Room;
                p.Allergies = p.Allergies;
                p.CodeStatus = p.CodeStatus;
                p.Medications = p.Medications;
            }
        }

        [TestMethod]
        public void MedicationsProperties()
        {
            if (medsID > -1)
            {
                Medications m = new Medications(medsID);
                m.ID = m.ID;
                m.PatientID = patientID;
                m.MedName = m.MedName;
                m.Symptom = m.Symptom;
                m.Dose = m.Dose;
                m.Route = m.Route;
                m.MedTime = m.MedTime;
            }
        }

        [TestMethod]
        public void MedsTakenHistoryProperties()
        {
            if (medHist > -1)
            {
                MedsTakenHistory m = new MedsTakenHistory(medHist);
                m.ID = m.ID;
                m.PatientID = patientID;
                m.MedID = medsID;
                m.TimeTaken = m.TimeTaken;
            }
        }

        [TestInitialize]
        public void TestLoadUp()
        {
            DataSet ds;
            data = new DataConnection();
            string sql = "select top(1) ID from Medications";
            ds = data.Exec(sql);
            if(ds.Tables[0].Rows.Count > 0)
                medsID = (int)ds.Tables[0].Rows[0]["ID"];

            sql = "select top(1) ID from Patient";
            ds = data.Exec(sql);
            if (ds.Tables[0].Rows.Count > 0)
                patientID = (int)ds.Tables[0].Rows[0]["ID"];

            sql = "select top(1) ID from MedsTakenHistory";
            ds = data.Exec(sql);
            System.Console.WriteLine(ds.Tables[0].Rows.Count);
            if (ds.Tables[0].Rows.Count > 0)
                medHist = (int)ds.Tables[0].Rows[0]["ID"];
        }
    }
}
