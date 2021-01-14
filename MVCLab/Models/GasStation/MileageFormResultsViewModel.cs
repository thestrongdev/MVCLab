using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLab.Models.GasStation
{
    public class MileageFormResultsViewModel
    {
        public int Mileage { get; set; }
        public int Gallons { get; set; }

        public int remainingMiles { get; set; }

        public int TripDistance { get; set; }

        public bool enoughGas { get; set; }

        public string userNotification { get; set; }
    }
}
