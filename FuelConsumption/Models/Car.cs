using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumption.Models
{
    class Car
    {
        public string CarRegisterNumber { get; }

        public string CarMake { get; }

        public string CarModel { get; }

        public Car(string carRegisterNumber, string carMake, string carModel)
        {
            CarRegisterNumber = carRegisterNumber;
            CarMake = carMake;
            CarModel = carModel;
        }
    }
}
