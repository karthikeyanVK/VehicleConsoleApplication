using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApplication
{
    class Sedancar : Car
    {
        public override void AboutVehicle()
        {
            Console.WriteLine("This Vehile has Four wheels");
            Console.WriteLine("This only Runs in Normal Road");
            Console.WriteLine("Seating Capacity in 4");
        }
    }
}
