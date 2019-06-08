namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var departements = new List<Department>();

            var numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEmployees; i++)
            {
                var inputArray = Console.ReadLine()
                    .Split();
                
                var name = inputArray[0];
                var salary = decimal.Parse(inputArray[1]);
                var position = inputArray[2];
                var department = inputArray[3];

                if (!departements.Any(d => d.Name == department))
                {
                    departements.Add(new Department(department));
                }

                Employee currentEmployee = null;

                if (inputArray.Length == 4)
                {
                    currentEmployee = new Employee(name, salary, position, departements.Find(d => d.Name == department));
                }

                else if (inputArray.Length == 5)
                {
                    if (int.TryParse(inputArray[4], out int age))
                    {
                        currentEmployee = new Employee(name, salary, position, departements.Find(d => d.Name == department), age);
                    }

                    else
                    {
                        var email = inputArray[4];

                        currentEmployee = new Employee(name, salary, position, departements.Find(d => d.Name == department), email);
                    }
                }

                else
                {
                    var email = inputArray[4];
                    var age = int.Parse(inputArray[5]);

                    currentEmployee = new Employee(name, salary, position, departements.Find(d => d.Name == department), email, age);
                }

                departements
                    .Find(d => d.Name == department)
                    .Employees
                    .Add(currentEmployee);
            }

            Department highestAverageSalaryDepartement = departements
                .OrderByDescending(d => d.GetAverageSalary())
                .First();

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartement.Name}");

            foreach (var employee in highestAverageSalaryDepartement
                .Employees
                .OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}