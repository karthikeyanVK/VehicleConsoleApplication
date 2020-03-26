using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApplication
{
    class WheeledVehicle : Vehicle
    {
       public virtual void AboutVehicle()
        {
            Console.WriteLine("This vehicle has wheels");
            Console.WriteLine("Runs in road only");
        }
    }
}
