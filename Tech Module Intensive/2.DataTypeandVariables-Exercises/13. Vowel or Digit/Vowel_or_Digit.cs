using System;
using System.Linq;

namespace _13.Vowel_or_Digit
{
    public class Vowel_or_Digit
    {
        public static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());

            if (char.IsDigit(symbol))
            {
                Console.WriteLine("digit");
            }

            else if ("aeiouy".Contains(symbol))
            {
                Console.WriteLine("vowel");
            }

            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
