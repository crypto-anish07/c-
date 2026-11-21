using System;

public partial class Hospital
{
    public string Location { get; set; }
    public int Capacity { get; set; }

    public void DisplayLocation()
    {
        Console.WriteLine("Location      : " + Location);
        Console.WriteLine("Capacity      : " + Capacity);
    }
}