using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            
            while (line != "end")
            {
                string[] tokens = line
                    .Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);

                string coursName = tokens[0];

                string studentName = tokens[1];

                if (!courses.ContainsKey(coursName))
                {
                    courses.Add(coursName, new List<string>());
                }

                courses[coursName].Add(studentName);

                line = Console.ReadLine();
            }

            foreach (var kvp in courses.OrderByDescending(v => v.Value.Count))
            {
                string currentCourse = kvp.Key;

                int sumOfContestLants = kvp.Value.Count;

                Console.WriteLine($"{currentCourse}: {sumOfContestLants}");

                foreach (var studentName in kvp.Value.OrderBy(s => s))
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
