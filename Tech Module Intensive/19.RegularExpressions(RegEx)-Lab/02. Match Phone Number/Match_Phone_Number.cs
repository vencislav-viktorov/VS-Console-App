using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    public class Match_Phone_Number
    {
        public static void Main()
        {
            string regex = @"\+359([- ])2\1\d{3}\1\d{4}\b";

            MatchCollection matches = Regex.Matches(Console.ReadLine(), regex);

            var validPhones = matches.Cast<Match>().ToList();

            Console.WriteLine(String.Join(", ", validPhones));
        }
    }
}
