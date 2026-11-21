
using System;

namespace lab21
{
    internal class Program
    {
        enum Department
        {
            Computer_Science = 1,
            Management,
            Humanities
        }

        enum College
        {
            St_Xaviers_College = 1,
            Trinity_International_College,
            Kathmandu_Model_College,
            Islington_College
        }

        static void ListDepartments()
        {
            Console.WriteLine("Departments:");

            foreach (var dept in Enum.GetValues(typeof(Department)))
            {
                Console.WriteLine(dept);
            }
        }

        static void ListColleges()
        {
            Console.WriteLine("\nColleges:");

            foreach (var college in Enum.GetValues(typeof(College)))
            {
                Console.WriteLine(college);
            }
        }

        static void Main(string[] args)
        {
            ListDepartments();
            ListColleges();

            Console.ReadLine();
        }
    }
}
