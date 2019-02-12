using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            var countChar = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];

                if (letter != ' ')
                {
                    if (!countChar.ContainsKey(letter))
                    {
                        countChar[letter] = 0;
                    }

                    countChar[letter]++;
                }
            }

            foreach (var kvp in countChar)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
