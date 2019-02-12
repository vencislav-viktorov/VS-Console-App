using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = new List<double>();
                }

                studentGrades[name].Add(grade);
            }

            Dictionary<string, List<double>> filteredStudentGrades = studentGrades
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in filteredStudentGrades)
            {
                string name = kvp.Key;

                List<double> grades = kvp.Value;

                Console.WriteLine($"{name} -> {grades.Average():f2}");
            }
        }
    }
}
