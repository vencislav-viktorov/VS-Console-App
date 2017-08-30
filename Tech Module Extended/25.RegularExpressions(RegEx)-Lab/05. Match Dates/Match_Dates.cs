using System;
using System.Text.RegularExpressions;

namespace _05.Match_Dates
{
    public class Match_Dates
    {
        public static void Main()
        {
            var regex = new Regex(@"(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})");

            var currentDates = regex.Matches(Console.ReadLine());

            foreach (Match date in currentDates)
            {
                var day = date.Groups["day"].Value;

                var month = date.Groups["month"].Value;

                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
