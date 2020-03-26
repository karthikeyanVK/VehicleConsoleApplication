using System;

namespace VehicleConsoleApplication
{
    class Program
    {
        public static void DriveSedanCar()
        {
            Sedancar sedanObj = new Sedancar();
            Console.WriteLine("1. Move Forward 2. Move Backward 3. GetCurrentPossition 4. About Vehicle 0.GetOutFromvehicle");
            while (true)
            {
                string driveOption = Console.ReadLine();
                switch (driveOption)
                {
                    case "1":
                        sedanObj.MoveForward();
                        break;
                    case "2":
                        sedanObj.MoveBackward();
                        break;
                    case "3":
                        sedanObj.CurrentPosition();
                        break;
                    case "4":
                        sedanObj.AboutVehicle();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Wrong One, Choose Correct Drive Option");
                        break;
                }

            }

        }
        public static void DriveSuvCar()
        {
            Suvcar suvObj = new Suvcar();
            Console.WriteLine("1. Move Forward 2. Move Backward 3. GetCurrentPossition 4. About Vehicle 0.GetOutFromvehicle");
            while (true)
            {
                string driveOption = Console.ReadLine();
                switch (driveOption)
                {
                    case "1":
                        suvObj.MoveForward();
                        break;
                    case "2":
                        suvObj.MoveBackward();
                        break;
                    case "3":
                        suvObj.CurrentPosition();
                        break;
                    case "4":
                        suvObj.AboutVehicle();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Wrong One, Choose Correct");
                        break;
                }

            }
        }
        public static void DriveBiCycle()
        {
            Bicycle bicylceObj = new Bicycle();
            Console.WriteLine("1. Move Forward 2. Move Backward 3. GetCurrentPossition 4. About Vehicle 0.GetOutFromvehicle");
            while (true)
            {
                string driveOption = Console.ReadLine();
                switch (driveOption)
                {
                    case "1":
                        bicylceObj.MoveForward();
                        break;
                    case "2":
                        bicylceObj.MoveBackward();
                        break;
                    case "3":
                        bicylceObj.CurrentPosition();
                        break;
                    case "4":
                        bicylceObj.AboutVehicle();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Wrong One, Choose Correct Drive Option");
                        break;
                }

            }
        }
        public static void DriveBoat()
        {
            Boat boatObj = new Boat();
            Console.WriteLine("1. Move Forward 2. Move Backward 3. GetCurrentPossition 0.GetOutFromvehicle");
            while (true)
            {
                string driveOption = Console.ReadLine();
                switch (driveOption)
                {
                    case "1":
                        boatObj.MoveForward();
                        break;
                    case "2":
                        boatObj.MoveBackward();
                        break;
                    case "3":
                        boatObj.CurrentPosition();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Wrong One, Choose Correct");
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
                        DriveSedanCar();
                        break;
                    case "2":
                        DriveSuvCar();
                        break;
                    case "3":
                        DriveBiCycle();
                        break;
                    case "4":
                        DriveBoat();
                        break;
                    default:
                        Console.WriteLine("Wrong One, Choose the Correct Vehicle");
                        break;

                }
            }
        }
    }
}
