using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.User_Logs
{
    public class User_Logs
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> userLogs =
                new SortedDictionary<string, Dictionary<string, int>>();

            char[] splitters = { ' ', '=' };

            string[] commandLine = Console.ReadLine().
                Split(splitters, StringSplitOptions.RemoveEmptyEntries).Where(entry => !entry.Equals("IP") &&
                !entry.Equals("message") && !entry.Equals("user")).ToArray();

            while (!commandLine[0].Equals("end"))
            {
                string ip = commandLine[0];

                string userName = commandLine[2];

                InsertUser(userLogs, userName);

                InsertIps(userLogs, userName, ip);

                commandLine = Console.ReadLine().
                    Split(splitters, StringSplitOptions.RemoveEmptyEntries).Where(entry => !entry.Equals("IP") &&
                    !entry.Equals("message") && !entry.Equals("user")).ToArray();
            }

            PrintUserLogs(userLogs);

        }

        private static void PrintUserLogs(SortedDictionary<string, Dictionary<string, int>> userLogs)
        {
            foreach (KeyValuePair<string, Dictionary<string, int>> userEntry in userLogs)
            {
                Console.WriteLine(userEntry.Key + ": ");

                string ipString = "";

                foreach (KeyValuePair<string, int> ipInformation in userEntry.Value)
                {
                    ipString += $"{ipInformation.Key} => {ipInformation.Value}, ";
                }

                ipString = ipString.Substring(0, ipString.Length - 2);

                ipString += ".";

                Console.WriteLine(ipString);
            }
        }

        private static void InsertIps(SortedDictionary<string, Dictionary<string, int>> userLogs,
            string userName, string ip)
        {
            if (!userLogs[userName].ContainsKey(ip))
            {
                userLogs[userName].Add(ip, 0);
            }

            userLogs[userName][ip]++;
        }

        private static void InsertUser(SortedDictionary<string, Dictionary<string, int>> userLogs, string userName)
        {
            if (!userLogs.ContainsKey(userName))
            {
                userLogs.Add(userName, new Dictionary<string, int>());
            }
        }
    }
}
