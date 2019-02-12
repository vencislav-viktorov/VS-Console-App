using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<Employee>> employees = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < lineCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string name = input[0];

                double salary = double.Parse(input[1]);

                string department = input[2];

                Employee employee = new Employee(name, salary, department);

                if (!employees.ContainsKey(department))
                {
                    employees.Add(department, new List<Employee>());
                }

                employees[department].Add(employee);
            }

            foreach (var employee in employees.OrderByDescending(x => x.Value.Average(y => y.Salary)))
            {
                Console.WriteLine($"Highest Average Salary: {employee.Key}");

                foreach (var salary in employee.Value.OrderByDescending(x => x.Salary))
                {
                    Console.WriteLine($"{salary.Name} {salary.Salary:F2}");
                }

                break;
            }
        }
    }
}
