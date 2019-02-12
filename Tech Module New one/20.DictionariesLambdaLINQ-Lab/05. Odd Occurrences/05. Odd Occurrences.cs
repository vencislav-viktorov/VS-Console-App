using System;
using System.Collections.Generic;

namespace _05._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (!counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase] = 0;
                    //counts.Add(wordInLowerCase, 0);
                }

                counts[wordInLowerCase]++;
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
