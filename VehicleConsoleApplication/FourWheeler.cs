using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApplication
{
    class FourWheeler : WheeledVehicle
    {
        public override void AboutVehicle()
        {
            Console.WriteLine("This Vehile has Four wheels");
            Console.WriteLine("This only Runs in Road");
            Console.WriteLine("Seating Capacity in Based on type of Vehicle");
        }
    }
}
