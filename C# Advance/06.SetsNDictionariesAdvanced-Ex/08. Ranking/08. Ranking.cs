using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main()
        {
            var contestWithPass = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "end of contests")
            {
                if (input.Contains(':'))
                {
                    var contestInfo = input.Split(':');

                    contestWithPass[contestInfo[0]] = contestInfo[1];
                }

                input = Console.ReadLine();
            }

            var users = new SortedDictionary<string, Dictionary<string, int>>();

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                var userInfo = input.Split("=>");

                var contest = userInfo[0];
                var pass = userInfo[1];
                var userName = userInfo[2];
                var userPoints = int.Parse(userInfo[3]);

                if (contestWithPass.ContainsKey(contest) && contestWithPass[contest].Equals(pass))
                {
                    if (users.ContainsKey(userName) == false)
                    {
                        users.Add(userName, new Dictionary<string, int>());
                    }

                    if (users[userName].ContainsKey(contest) == false)
                    {
                        users[userName][contest] = userPoints;
                    }

                    else if (users[userName][contest] < userPoints)
                    {
                        users[userName][contest] = userPoints;
                    }
                }

                input = Console.ReadLine();
            }

            var bestCandidate = users.OrderByDescending(u => u.Value.Values.Sum()).First();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value.Values.Sum()} points.");

            Console.WriteLine("Ranking:");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}");

                foreach (var contest in user.Value.OrderByDescending(kvp => kvp.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}