using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Logs_Aggregator
{
    public class Logs_Aggregator
    {
        public static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, int>> userLogs =
                new SortedDictionary<string, SortedDictionary<string, int>>();

            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                string commandLine = Console.ReadLine();

                string[] commandArgs = commandLine
                    .Split(new char[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);

                string ip = commandArgs[0];

                string userName = commandArgs[1];

                int duration = int.Parse(commandArgs[2]);

                InsertUser(userLogs, userName);

                InsertIp(userLogs, userName, ip, duration);
            }

            PrintUserLogs(userLogs);
        }

        private static void PrintUserLogs(SortedDictionary<string, SortedDictionary<string, int>> userLogs)
        {
            foreach (var userEntry in userLogs)
            {
                int durationTotal = userEntry.Value.Values.Sum();

                List<string> entryIps = userEntry.Value.Keys.ToList();

                Console.WriteLine("{0}: {1} [{2}]", userEntry.Key, durationTotal, string.Join(", ", entryIps));
            }
        }

        private static void InsertIp(SortedDictionary<string, SortedDictionary<string, int>>
            userLogs, string userName, string ip, int duration)
        {
            if (!userLogs[userName].ContainsKey(ip))
            {
                userLogs[userName].Add(ip, 0);
            }

            userLogs[userName][ip] += duration;
        }

        private static void InsertUser(SortedDictionary<string, SortedDictionary<string, int>>
            userLogs, string userName)
        {
            if (!userLogs.ContainsKey(userName))
            {
                userLogs.Add(userName, new SortedDictionary<string, int>());
            }
        }
    }
}
