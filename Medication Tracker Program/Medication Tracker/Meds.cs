using Data;
using System;

namespace Medication_Tracker
{
    class Meds : dbObject
    {
        public Meds()
        {

        }

        public Meds(int medID, string medName, string symptom, string dose, string route, DateTime medTime)
        {
            ID = medID;
            MedName = medName;
            Symptom = symptom;
            Dose = dose;
            Route = route;
            MedTime = medTime;
        }

        public string MedName { get; set; }
        public string Symptom { get; set; }
        public string Dose { get; set; }
        public string Route { get; set; }
        public DateTime MedTime { get; set; }
    }


}
