using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Match_Dates
{
    public class Match_Dates
    {
        public static void Main()
        {
            var regex = @"\b(?<day>\d{2})([\.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            MatchCollection validDates = Regex.Matches(Console.ReadLine(), regex);

            foreach (Match date in validDates)
            {
                var str = new StringBuilder();

                var day = date.Groups["day"];

                var month = date.Groups["month"];

                var year = date.Groups["year"];

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
