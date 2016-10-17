namespace Problem_04.Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            FindDepartmentWithGreatestAverageSalary();
        }

        private static void FindDepartmentWithGreatestAverageSalary()
        {
            var numPeople = int.Parse(Console.ReadLine());
            var people = new List<Employee>();
            for (var i = 0; i < numPeople; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var salary = decimal.Parse(input[1]);
                var position = input[2];
                var department = input[3];
                string email = null;
                var age = 0;
                if (input.Length == 5)
                {
                    if (!int.TryParse(input[4], out age))
                    {
                        email = input[4];
                    }
                }

                if (input.Length == 6)
                {
                    email = input[4];
                    age = int.Parse(input[5]);
                }
                var person = new Employee(name, salary, position, department, email, age);
                people.Add(person);
            }

            var groups = people.GroupBy(pers => pers.department).ToList();
            var departmentWithHighestAverageSalary = groups.OrderByDescending(depart => depart.Average(pers => pers.salary)).FirstOrDefault();
            Console.WriteLine($"Highest Average Salary: {departmentWithHighestAverageSalary.Key}");
            var departmentEmployees = departmentWithHighestAverageSalary.ToList();
            departmentEmployees.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, departmentEmployees));

        }
    }
}
