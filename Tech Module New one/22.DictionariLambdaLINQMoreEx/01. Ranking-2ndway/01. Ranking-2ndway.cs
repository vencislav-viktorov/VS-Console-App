using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            var examNameAndPassword = new Dictionary<string, string>();

            var input = Console.ReadLine()
                .Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end of contests")
            {
                string examName = input[0];

                string examPassword = input[1];

                examNameAndPassword[examName] = examPassword;

                input = Console.ReadLine()
                    .Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
            }

            var students = new Dictionary<string, Dictionary<string, int>>();

            var submission = Console.ReadLine()
                .Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);

            while (submission[0] != "end of submissions")
            {
                string examName = submission[0];

                string examPassword = submission[1];

                string user = submission[2];

                int points = int.Parse(submission[3]);

                if (examNameAndPassword.ContainsKey(examName) &&
                    examNameAndPassword[examName] == examPassword)
                {
                    if (!students.ContainsKey(user))
                    {
                        students[user] = new Dictionary<string, int>();

                        students[user].Add(examName, points);
                    }

                    else
                    {
                        if (!students[user].ContainsKey(examName))
                        {
                            students[user].Add(examName, points);
                        }

                        else if (students[user][examName] < points)
                        {
                            students[user][examName] = points;
                        }
                    }
                }

                submission = Console.ReadLine()
                    .Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);
            }

            var bestCandidate = students.OrderByDescending(x => x.Value.Values.Sum()).First();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total" +
                $" {bestCandidate.Value.Values.Sum()} points.");

            Console.WriteLine("Ranking:");

            var result = students.OrderBy(x => x.Key);

            foreach (var student in result)
            {
                Console.WriteLine(student.Key);

                var pairs = student.Value.OrderByDescending(x => x.Value);

                foreach (var currentContest in pairs)
                {
                    Console.WriteLine($"#  {currentContest.Key} -> {currentContest.Value}");
                }
            }
        }
    }
}
