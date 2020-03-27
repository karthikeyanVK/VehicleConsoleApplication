using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApplication
{
    class Boat : SeaVehicle
    {
         public override void TurnLeft()
        {
            Console.WriteLine( VehicleName +" Moves Right Direction");
        }
        public override void TurnRight()
        {
            Console.WriteLine( VehicleName + " Moves Left Direction");
        }
    }
}
