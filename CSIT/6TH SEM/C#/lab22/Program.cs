
using System;

namespace lab22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            College college = new College();

            department.Name = "CSIT";
            department.Code = 7;

            college.Name = "Samriddhi College";
            college.Location = "Lokanthali, Bhaktapur";

            // Display structure data
            DisplayDepartment(department);
            DisplayCollege(college);

            Console.ReadLine();
        }

        static void DisplayDepartment(Department dept)
        {
            Console.WriteLine("Department Details:");
            Console.WriteLine("Department Name: " + dept.Name);
            Console.WriteLine("Department Code: " + dept.Code);
        }

        static void DisplayCollege(College college)
        {
            Console.WriteLine("\nCollege Details:");
            Console.WriteLine("College Name: " + college.Name);
            Console.WriteLine("College Location: " + college.Location);
        }
    }

    // Structure for Department
    struct Department
    {
        public string Name;
        public int Code;
    }

    // Structure for College
    struct College
    {
        public string Name;
        public string Location;
    }
}
