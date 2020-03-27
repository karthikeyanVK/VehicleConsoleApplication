using System;

namespace VehicleConsoleApplication
{
    class Program
    {
        static dynamic v = null;
        public static void Drive()
        {           
            Console.WriteLine("1. Move Forward 2. Move Backward 3. GetCurrentPossition 4. About Vehicle");
            Console.WriteLine("5. TurnLeft 6. TurnRight 0. GetOutFromVehicle" );
            while (true)
            {
                string driveOption = Console.ReadLine();
                switch (driveOption)
                {
                    case "1":
                        v.MoveForward();
                        break;
                    case "2":
                        v.MoveBackward();                       
                        break;
                    case "3":
                        v.CurrentPosition();
                        break;
                    case "4":
                        v.AboutVehicle();
                        break;
                    case "5":
                        v.TurnLeft();
                        break;
                    case "6":
                        v.TurnRight();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Wrong One, Choose Correct Drive Option");
                        break;
                }

            }

        }
        
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine("Choose your Vehicle");
                Console.WriteLine(" 1.Sedan Car 2. SUV Car 3. Bicycle 4. Boat");
                string vehicleOption = Console.ReadLine();
               
                switch (vehicleOption)
                {
                    case "1":
                        v = new Sedancar();
                        Drive();
                        break;
                    case "2":
                        v = new Suvcar();
                        Drive();
                        break;
                    case "3":
                        v = new Bicycle();
                        Drive();
                        break;
                    case "4":
                        v = new Boat();
                        Drive();
                        break;
                }
            }
        }
    }
}
