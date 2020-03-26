using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApplication
{
    class Suvcar : Car
    {
        public override void AboutVehicle()
        {
            Console.WriteLine("This Vehile has Four wheels");
            Console.WriteLine("This only Runs in Rugged Road as Well as Normal Road");
            Console.WriteLine("Seating Capacity in 6");
        }
    }
}
