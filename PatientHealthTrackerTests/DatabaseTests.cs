using Medication_Tracker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PatientHealthTrackerTests
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void AddUpdateDeletePatientTest()
        {
            Patient p = new Patient();
            try
            {
                p.Pulse = 1;
                p.BloodPressureTop = 1;
                p.BloodPressureBottom = 1;
                p.Oxygen = 1;
                p.Respiration = 1;
                p.Temp = (decimal)1.1;
                p.PatientName = "Jessica";
                p.DateOfBirth = DateTime.Now;
                p.Room = 101;
                p.Allergies = "Peanut Butter";
                p.CodeStatus = "Full";
                p.Save(true);
                p.Room = 202;
                p.Save(false);
                int id = p.ID;
                p = new Patient(id);
                Assert.AreEqual(p.Room, 202);
            }
            finally
            {
                p.Delete();
                p.Dispose();
            }
        }

        [TestMethod]
        public void AddUpdateDeleteMedsTakenHistory()
        {
            MedsTakenHistory m = new MedsTakenHistory();
            try
            {
                m.MedID = 1;
                m.PatientID = 1;
                m.TimeTaken = DateTime.Now;
                m.Save(true);
                m.MedID = 2;
                m.Save(false);
                int id = m.ID;
                m = new MedsTakenHistory(id);
                Assert.AreEqual(m.MedID, 2);
            }
            finally
            {
                m.Delete();
                m.Dispose();
            }
        }
    }
}
