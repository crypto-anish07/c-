using System;

public partial class Hospital
{
    public int HospitalId { get; set; }
    public string HospitalName { get; set; }

    public void DisplayHospital()
    {
        Console.WriteLine("Hospital ID   : " + HospitalId);
        Console.WriteLine("Hospital Name : " + HospitalName);
    }
}