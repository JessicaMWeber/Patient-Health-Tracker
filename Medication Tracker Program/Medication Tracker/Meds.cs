using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medication_Tracker
{
    class Meds
    {
        public Meds()
        {

        }
        public Meds(int mid, string mn, string d, string r, DateTime mt)
        {
            MedID = mid;
            MedName = mn;
            Dose = d;
            Route = r;
            MedTime = mt;
        }

        public int MedID { get; set; }
        public string MedName { get; set; }
        public string Dose { get; set; }
        public string Route { get; set; }
        public DateTime MedTime { get; set; }

    }


}
