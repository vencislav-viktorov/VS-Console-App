using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    public class Weather
    {
        public static void Main()
        {
            var pattern = @"(?<country>[A-Z]{2})(?<temperature>\d+\.\d+)(?<weather>[A-Za-z]+)\|";

            var matches = new List<Match>();

            var command = Console.ReadLine();

            while (string.Compare(command, "end") != 0)
            {
                var match = Regex.Match(command, pattern);

                if (match.Length == 0)
                {
                    command = Console.ReadLine();

                    continue;
                }

                var repeatMatchIndex = matches.FindIndex(x => x.Groups["country"].Value == match.Groups["country"].Value);

                if (repeatMatchIndex >= 0)
                {
                    matches.RemoveAt(repeatMatchIndex);
                }

                matches.Add(match);

                command = Console.ReadLine();
            }

            var sortedMatches = matches.OrderBy(x => double.Parse(x.Groups["temperature"].Value));

            foreach (var match in sortedMatches)
            {
                Console.WriteLine($"{match.Groups["country"].Value} => {double.Parse(match.Groups["temperature"].Value):f2} => {match.Groups["weather"].Value}");
            }
        }
    }
}
