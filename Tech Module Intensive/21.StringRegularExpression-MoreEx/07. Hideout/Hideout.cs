using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.Hideout
{
    public class Hideout
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            while (true)
            {
                var input = Console.ReadLine().Split().ToList();

                string pattern = Regex.Escape(input[0]) + "{" + input[1] + ",}";

                var match = Regex.Match(text, pattern);

                if (match.Length == 0) continue;

                Console.WriteLine($"Hideout found at index {text.IndexOf(match.Value)} and it is with size {match.Value.Length}!");

                break;
            }
        }
    }
}
