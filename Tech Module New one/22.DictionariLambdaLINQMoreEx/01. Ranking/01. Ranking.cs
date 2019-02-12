using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ExamNameAndPassword = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> submissionPoints = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] tokens = input.Split(new char[] { ':' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string examName = tokens[0];

                string examPassword = tokens[1];

                ExamNameAndPassword[examName] = examPassword;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] tokens = input.Split(new string[] { "=>" },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string examName = tokens[0];

                string examPassword = tokens[1];

                string user = tokens[2];

                int points = int.Parse(tokens[3]);

                if (ExamNameAndPassword.ContainsKey(examName) && ExamNameAndPassword[examName] == examPassword)
                {
                    if (!submissionPoints.ContainsKey(user))
                    {
                        submissionPoints[user] = new Dictionary<string, int>();

                        submissionPoints[user].Add(examName, points);
                    }

                    else
                    {
                        if (!submissionPoints[user].ContainsKey(examName))
                        {
                            submissionPoints[user].Add(examName, points);
                        }

                        else
                        {
                            if (points > submissionPoints[user][examName])
                            {
                                submissionPoints[user][examName] = points;
                            }
                        }
                    }
                }
            }

            var submissionPointsFiltered = submissionPoints.OrderByDescending(x => x.Value.Values.Sum()).Take(1);

            int bestPoints = 0;

            string bestCandidate = string.Empty;

            foreach (var user in submissionPointsFiltered)
            {
                bestCandidate = user.Key;

                foreach (var exam in user.Value)
                {
                    bestPoints += exam.Value;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");

            Console.WriteLine("Ranking: ");

            foreach (var kvp in submissionPoints.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var exam in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {exam.Key} -> {exam.Value}");
                }
            }
        }
    }
}
