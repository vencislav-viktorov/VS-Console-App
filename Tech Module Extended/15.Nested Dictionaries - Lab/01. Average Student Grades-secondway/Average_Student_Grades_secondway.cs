using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Average_Student_Grades_secondway
{
    public class Average_Student_Grades_secondway
    {
        public static void Main()
        {
            var result = new Dictionary<string, List<double>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var nameAndGrade = Console.ReadLine().Split(new[] { " " }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                var name = nameAndGrade[0];

                var grade = double.Parse(nameAndGrade[1]);

                if (!result.ContainsKey(name))
                {
                    result[name] = new List<double>();
                }

                result[name].Add(grade);
            }

            var avg = 0.0;

            foreach (var item in result)
            {
                Console.Write(item.Key + " ->");

                foreach (var grades in item.Value)
                {
                    avg = item.Value.Average();

                    Console.Write($" {grades:f2}");
                }

                Console.WriteLine($" (avg: {avg:f2})");
            }
        }
    }
}
