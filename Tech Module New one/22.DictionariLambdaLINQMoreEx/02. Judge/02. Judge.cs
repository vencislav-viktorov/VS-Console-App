using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> contestUserPoints = new Dictionary<string, Dictionary<string, int>>();

            while (input != "no more time")
            {
                string[] tokens = input
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string username = tokens[0];

                string examName = tokens[1];

                int points = int.Parse(tokens[2]);

                if (!contestUserPoints.ContainsKey(examName))
                {
                    contestUserPoints.Add(examName, new Dictionary<string, int>());
                }

                if (!contestUserPoints[examName].ContainsKey(username))
                {
                    contestUserPoints[examName].Add(username, 0);
                }

                //if (contestUserPoints[examName][username] < points)
                //{
                //    contestUserPoints[examName][username] = points;
                //}

                points = Math.Max(points, contestUserPoints[examName][username]);

                contestUserPoints[examName][username] = points;


                input = Console.ReadLine();
            }

            foreach (var exam in contestUserPoints)
            {
                Console.WriteLine($"{exam.Key}: {exam.Value.Values.Count} participants");

                int counter = 1;

                foreach (var user in exam.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{counter}. {user.Key} <::> {user.Value}");

                    counter++;
                }
            }

            Dictionary<string, int> individualPoints = new Dictionary<string, int>();

            Console.WriteLine("Individual standings:");

            foreach (var exam in contestUserPoints)
            {
                foreach (var user in exam.Value)
                {
                    if (!individualPoints.ContainsKey(user.Key))
                    {
                        individualPoints.Add(user.Key, 0);
                    }

                    individualPoints[user.Key] += user.Value;
                }
            }

            int counter2 = 1;

            foreach (var user in individualPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{counter2}. {user.Key} -> {user.Value}");

                counter2++;
            }
        }
    }
}
