using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQLab
{
    public class tblEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public decimal Salary { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime Dob { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<tblEmployee> emp = new List<tblEmployee>()
            {
                new tblEmployee{Id=1,Name="Sunil Chaudhary",Gender="Male",Country="Nepal",Salary=40000,RegDate=new DateTime(2024,8,27),Dob=new DateTime(1999,8,27)},
                new tblEmployee{Id=2,Name="Suraj Sapkota",Gender="Male",Country="Nepal",Salary=50000,RegDate=new DateTime(2024,8,27),Dob=new DateTime(1998,1,3)},
                new tblEmployee{Id=3,Name="Sita Thapa",Gender="Female",Country="China",Salary=80000,RegDate=new DateTime(2024,8,27),Dob=new DateTime(1997,2,24)},
                new tblEmployee{Id=4,Name="Mohan Ghimire",Gender="Male",Country="India",Salary=30000,RegDate=new DateTime(2024,8,26),Dob=new DateTime(1995,5,26)},
                new tblEmployee{Id=5,Name="Dina Shrestha",Gender="Female",Country="Nepal",Salary=20000,RegDate=new DateTime(2024,8,25),Dob=new DateTime(1994,8,27)},
                new tblEmployee{Id=6,Name="Ritesh Kafle",Gender="Male",Country="India",Salary=50000,RegDate=new DateTime(2024,8,25),Dob=new DateTime(1997,8,27)},
                new tblEmployee{Id=7,Name="Rima Nepal",Gender="Female",Country="India",Salary=90000,RegDate=new DateTime(2024,8,26),Dob=new DateTime(2000,8,27)}
            };

            // 1. Fetch all records
            Console.WriteLine("\n1. All Records\n");
            foreach (var e in emp)
                Console.WriteLine($"{e.Id} {e.Name}");

            // 2. Name Ascending
            Console.WriteLine("\n2. Name Ascending");
            foreach (var e in emp.OrderBy(x => x.Name))
                Console.WriteLine(e.Name);

            // 3. Name Descending
            Console.WriteLine("\n3. Name Descending");
            foreach (var e in emp.OrderByDescending(x => x.Name))
                Console.WriteLine(e.Name);

            // 4. Top 3 Records
            Console.WriteLine("\n4. Top 3 Records");
            foreach (var e in emp.Take(3))
                Console.WriteLine(e.Name);

            // 5. Average Salary
            Console.WriteLine("\n5. Average Salary");
            Console.WriteLine(emp.Average(x => x.Salary));

            // 6. Country Nepal or China
            Console.WriteLine("\n6. Nepal or China");
            foreach (var e in emp.Where(x => x.Country == "Nepal" || x.Country == "China"))
                Console.WriteLine(e.Name);

            // 7. Registered in August
            Console.WriteLine("\n7. Registered in August");
            foreach (var e in emp.Where(x => x.RegDate.Month == 8))
                Console.WriteLine(e.Name);

            // 8. Registered between 26/8/2024 and 28/8/2024
            Console.WriteLine("\n8. Registered between 26/8/2024 and 28/8/2024");
            foreach (var e in emp.Where(x => x.RegDate >= new DateTime(2024,8,26)
                                          && x.RegDate <= new DateTime(2024,8,28)))
                Console.WriteLine(e.Name);

            // 9. Order by Name then Salary
            Console.WriteLine("\n9. Order by Name then Salary");
            foreach (var e in emp.OrderBy(x => x.Name).ThenBy(x => x.Salary))
                Console.WriteLine($"{e.Name} {e.Salary}");

            // 10. Nepal and Salary >60000
            Console.WriteLine("\n10. Nepal and Salary >60000");
            foreach (var e in emp.Where(x => x.Country == "Nepal" && x.Salary > 60000))
                Console.WriteLine(e.Name);

            // 11. Sum Salary
            Console.WriteLine("\n11. Sum Salary");
            Console.WriteLine(emp.Sum(x => x.Salary));

            // 12. Max Salary
            Console.WriteLine("\n12. Max Salary");
            Console.WriteLine(emp.Max(x => x.Salary));

            // 13. Min Salary
            Console.WriteLine("\n13. Min Salary");
            Console.WriteLine(emp.Min(x => x.Salary));

            // 14. Id Name Salary
            Console.WriteLine("\n14. Id Name Salary");
            foreach (var e in emp.Select(x => new { x.Id, x.Name, x.Salary }))
                Console.WriteLine($"{e.Id} {e.Name} {e.Salary}");

            // 15. 30% Salary
            Console.WriteLine("\n15. 30% Salary");
            foreach (var e in emp.Select(x => new
            {
                x.Id,
                x.Name,
                Bonus = x.Salary * 0.30m
            }))
                Console.WriteLine($"{e.Id} {e.Name} {e.Bonus}");

            // 16. Name Starts With S
            Console.WriteLine("\n16. Name Starts With S");
            foreach (var e in emp.Where(x => x.Name.StartsWith("S")))
                Console.WriteLine(e.Name);

            // 17. Female Count
            Console.WriteLine("\n17. Female Count");
            Console.WriteLine(emp.Count(x => x.Gender == "Female"));

            // 18. Male & Female Count
            Console.WriteLine("\n18. Gender Wise Count");
            foreach (var g in emp.GroupBy(x => x.Gender))
                Console.WriteLine($"{g.Key} = {g.Count()}");

            // 19. Gender Wise Salary Sum
            Console.WriteLine("\n19. Gender Wise Salary Sum");
            foreach (var g in emp.GroupBy(x => x.Gender))
                Console.WriteLine($"{g.Key} = {g.Sum(x => x.Salary)}");
        }
    }
}