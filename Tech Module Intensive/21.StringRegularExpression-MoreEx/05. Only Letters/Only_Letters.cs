using System;
using System.Text.RegularExpressions;

namespace _05.Only_Letters
{
    public class Only_Letters
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var pattern = @"\d+([A-Za-z])";

            var result = Regex.Replace(text, pattern, @"$1$1");

            Console.WriteLine(result);
        }
    }
}
