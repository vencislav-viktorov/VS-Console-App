using System;
using System.Text.RegularExpressions;

namespace _05.Match_Numbers
{
    public class Match_Numbers
    {
        public static void Main()
        {
            var regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            var currentNumbers = regex.Matches(Console.ReadLine());

            foreach (var number in currentNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
