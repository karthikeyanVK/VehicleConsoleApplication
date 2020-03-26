using System;

namespace VehicleConsoleApplication
{
    class Program
    {
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
                        Sedancar sedanObj = new Sedancar();
                        Console.WriteLine("1. Move Forward 2. Move Backward 3. GetCurrentPossition");
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
                                default:
                                    Console.WriteLine("Wrong One, Choose Correct Drive Option");
                                    break;
                            }

                        }
                    case "2":
                        Suvcar suvObj = new Suvcar();
                        Console.WriteLine("1. Move Forward 2. Move Backward 3. GetCurrentPossition");
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
                                default:
                                    Console.WriteLine("Wrong One, Choose Correct");
                                    break;
                            }

                        }
                    case "3":
                        Bicycle bicylceObj = new Bicycle();
                        Console.WriteLine("1. Move Forward 2. Move Backward 3. GetCurrentPossition");
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
                                default:
                                    Console.WriteLine("Wrong One, Choose Correct Drive Option");
                                    break;
                            }

                        }
                    case "4":
                        Boat boatObj = new Boat();
                        Console.WriteLine("1. Move Forward 2. Move Backward 3. GetCurrentPossition");
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
                                default:
                                    Console.WriteLine("Wrong One, Choose Correct");
                                    break;
                            }

                        }
                    default:
                        Console.WriteLine("Wrong One, Choose the Correct Vehicle");
                        break;

                }
            }
        }
    }
}
