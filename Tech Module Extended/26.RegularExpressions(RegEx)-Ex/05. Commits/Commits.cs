using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05.Commits
{
    public class CommitsData
    {
        public string Hash { get; set; }

        public string Comment { get; set; }

        public decimal Additions { get; set; }

        public decimal Deletions { get; set; }

        public static CommitsData Parse(string a, string b, string c, string d)
        {
            return new CommitsData
            {
                Hash = a,

                Comment = b,

                Additions = decimal.Parse(c),

                Deletions = decimal.Parse(d)
            };
        }
    }

    public class Commits
    {
        public static void Main()
        {
            var URL = Console.ReadLine();

            var parsedCommitsData = new SortedDictionary<string/*name*/, 
                SortedDictionary<string/*repository*/, List<CommitsData>>>();

            while (URL != "git push")
            {
                var regex = new Regex(
                    @"https:\/\/github.com\/([A-Za-z-0-9]+)\/([A-Za-z-_]+)\/commit\/([a-f0-9]{40}),(.+?)[,](\d+)[,](\d+)");

                if (regex.IsMatch(URL))
                {
                    var extrakt = regex.Match(URL);

                    var currentCommit = new CommitsData();

                    currentCommit = CommitsData.Parse(extrakt.Groups[3].Value,

                        extrakt.Groups[4].Value, extrakt.Groups[5].Value, extrakt.Groups[6].Value);

                    if (!parsedCommitsData.ContainsKey(extrakt.Groups[1].Value))
                    {
                        parsedCommitsData[extrakt.Groups[1].Value] = new SortedDictionary<string, List<CommitsData>>();
                    }

                    if (!parsedCommitsData[extrakt.Groups[1].Value].ContainsKey(extrakt.Groups[2].Value))
                    {
                        parsedCommitsData[extrakt.Groups[1].Value][extrakt.Groups[2].Value] = new List<CommitsData>();
                    }

                    parsedCommitsData[extrakt.Groups[1].Value][extrakt.Groups[2].Value].Add(currentCommit);
                }

                URL = Console.ReadLine();
            }

            var totalAdditions = 0m;

            var totalDeletions = 0m;

            foreach (var user in parsedCommitsData)
            {
                Console.WriteLine($"{user.Key}:");

                foreach (var repo in parsedCommitsData[user.Key])
                {
                    Console.WriteLine($"  {repo.Key}:");

                    foreach (var commit in repo.Value)
                    {
                        totalAdditions += commit.Additions;

                        totalDeletions += commit.Deletions;

                        Console.Write($"    commit {commit.Hash}: {commit.Comment} ");

                        Console.WriteLine($"({commit.Additions} additions, {commit.Deletions} deletions)");
                    }

                    Console.WriteLine($"    Total: {totalAdditions} additions, {totalDeletions} deletions");

                    totalAdditions = 0;

                    totalDeletions = 0;
                }
            }
        }
    }
}