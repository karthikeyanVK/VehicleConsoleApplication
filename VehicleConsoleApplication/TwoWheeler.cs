using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApplication
{
    class TwoWheeler : WheeledVehicle
    {
        public override void AboutVehicle()
        {
            Console.WriteLine("This Vehile has Only Two wheels");
            Console.WriteLine("This only Runs in Road");
            Console.WriteLine("Seating Capacity in 2");
        }
    }
}
