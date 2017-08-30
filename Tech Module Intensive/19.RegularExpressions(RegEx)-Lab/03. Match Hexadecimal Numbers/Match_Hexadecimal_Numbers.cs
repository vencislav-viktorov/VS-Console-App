using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Match_Hexadecimal_Number
{
    public class Match_Hexadecimal_Numbers
    {
        public static void Main()
        {
            var hex = Regex.Matches(Console.ReadLine(), @"\b(?:0x)?[0-9A-F]+\b").Cast<Match>().ToList();

            Console.WriteLine(string.Join(" ", hex));
        }
    }
}
