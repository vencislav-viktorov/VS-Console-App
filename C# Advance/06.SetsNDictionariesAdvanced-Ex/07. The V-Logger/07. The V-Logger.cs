using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main()
        {
            var usernames = new HashSet<string>();
            var userFollowers = new Dictionary<string, HashSet<string>>();
            var userFollowing = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                var splitedInput = input.Split();

                if (splitedInput.Length == 4)
                {
                    var username = splitedInput[0];

                    if (usernames.Contains(username) == false)
                    {
                        usernames.Add(username);
                        userFollowers.Add(username, new HashSet<string>());
                        userFollowing.Add(username, new HashSet<string>());
                    }
                }

                else
                {
                    var heFollows = splitedInput[0];
                    var followed = splitedInput[2];

                    if (usernames.Contains(heFollows) &&
                        usernames.Contains(followed) &&
                        heFollows != followed)
                    {
                        userFollowers[followed].Add(heFollows);
                        userFollowing[heFollows].Add(followed);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {usernames.Count} vloggers in its logs.");

            var topUser = userFollowers
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => userFollowing[x.Key].Count)
                .FirstOrDefault();

            Console.WriteLine($"1. {topUser.Key} : {topUser.Value.Count} followers, {userFollowing[topUser.Key].Count} following");

            foreach (var username in topUser.Value.OrderBy(x => x))
            {
                Console.WriteLine($"*  {username}");
            }

            var count = 2;

            foreach (var kvp in userFollowers
                .Where(x => x.Key != topUser.Key)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => userFollowing[x.Key].Count()))
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value.Count} followers, {userFollowing[kvp.Key].Count} following");
                count++;
            }
        }
    }
}