using System;

class Program
{
    static void Main()
    {
        Hospital h = new Hospital();

        Console.Write("Enter Hospital ID: ");
        h.HospitalId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Hospital Name: ");
        h.HospitalName = Console.ReadLine();

        Console.Write("Enter Location: ");
        h.Location = Console.ReadLine();

        Console.Write("Enter Capacity: ");
        h.Capacity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nHospital Details");
        h.DisplayHospital();
        h.DisplayLocation();
    }
}