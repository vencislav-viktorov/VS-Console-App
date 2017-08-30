using System;
using System.Text.RegularExpressions;

namespace _05.Match_Numbers
{
    public class Match_Numbers
    {
        public static void Main()
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            MatchCollection numbers = Regex.Matches(Console.ReadLine(), regex);

            foreach (Match num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
