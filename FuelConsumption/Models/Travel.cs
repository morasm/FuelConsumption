using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumption.Models
{
    class Travel
    {
        public string TravelStart { get; }

        public string TravelTarget { get; }

        public float TravelStartMilleage { get; }

        public float TravelEndMilleage { get; }

        public Travel(string travelStart, string travelTarget, float travelStartMilleage, float travelEndMilleage)
        {
            TravelStart = travelStart;
            TravelTarget = travelTarget;
            TravelStartMilleage = travelStartMilleage;
            TravelEndMilleage = travelEndMilleage;
        }
    }
}
