using System;
using System.Text.RegularExpressions;

namespace _01.Censorship
{
    public class Censorship
    {
        public static void Main()
        {
            var pattern = Console.ReadLine();

            var text = Console.ReadLine();

            var replaced = Regex.Replace(text, $@"{pattern}", new string('*', pattern.Length));

            Console.WriteLine(replaced);
        }
    }
}
