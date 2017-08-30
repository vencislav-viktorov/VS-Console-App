using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    public class Cards
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            var regex = new Regex("(?<![0-9])(?:([2-9]|10)|(A|K|Q|J))+(S|H|D|C)");//"([1]?[0-9JKQA])([SHDC])");

            var matches = regex.Matches(inputString);

            var result = new List<string>();

            foreach (Match item in matches)
            {
                result.Add(item.Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}