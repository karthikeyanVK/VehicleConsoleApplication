using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleConsoleApplication
{
    class Vehicle
    {
        private string vehicleName;
        private int postionOfvehicle = 0;

        public Vehicle()
        {
            Console.WriteLine("Enter the Name of the Vehicle");
            this.vehicleName = Console.ReadLine();
            Console.WriteLine("Name of the vehicle : " + this.vehicleName);
        }
        public string VehicleName
        {
            get { return vehicleName; }
            set { vehicleName = value; }
        }
        public int MoveForward()
        {
            postionOfvehicle += 1;
            Console.WriteLine(vehicleName + " Moves Forward 1 Step");
            return postionOfvehicle;
        }
        public int MoveBackward()
        {
            postionOfvehicle -= 1;
            Console.WriteLine(vehicleName + " Moves Backward 1 Step");
            return postionOfvehicle;
        }
        public int CurrentPosition()
        {
            Console.WriteLine("Current Position of the " + vehicleName + "is " + postionOfvehicle);
            return postionOfvehicle;
        }
    }
}
