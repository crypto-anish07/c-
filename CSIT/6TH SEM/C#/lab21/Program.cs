using System;

namespace ConsoleApp3
{
    internal class Program
    {
        enum VehicleType
        {
            Car = 1,
            Bike,
            Bus,
            Truck,
            Van
        }
        static void DisplayFuelType(VehicleType vehicle)
        {
            switch (vehicle)
            {
                case VehicleType.Car:
                    Console.WriteLine($"{vehicle} Petrol.");
                    break;
                case VehicleType.Bike:
                    Console.WriteLine($"{vehicle} Petrol.");
                    break;
                case VehicleType.Bus:
                    Console.WriteLine($"{vehicle} Diesel.");
                    break;
                case VehicleType.Truck:
                    Console.WriteLine($"{vehicle} Diesel.");
                    break;
                case VehicleType.Van:
                    Console.WriteLine($"{vehicle} Diesel.");
                    break;
                default:
                    Console.WriteLine("Unknown vehicle type.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter vehicle type (1 for Car, 2 for Bike, 3 for Bus, 4 for Truck, 5 for Van):");
            int vehicleNo = Convert.ToInt32(Console.ReadLine());
            VehicleType vehicle = (VehicleType)vehicleNo;
            DisplayFuelType(vehicle);
            Console.ReadLine();
        }
    }
}
