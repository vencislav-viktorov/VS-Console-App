using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays_3rdway
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            List<string> result = new List<string>();

            for (int i = 0; i < sequence.Count; i++)
            {
                List<string> final = sequence[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                result.AddRange(final);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
