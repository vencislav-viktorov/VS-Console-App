using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main()
        {
            var firstSet = new HashSet<string>();
            var secondSet = new HashSet<string>();

            var setsLength = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < setsLength.Sum(); i++)
            {
                if (i < setsLength[0])
                {
                    firstSet.Add(Console.ReadLine());
                }

                else
                {
                    secondSet.Add(Console.ReadLine());
                }
            }

            Console.WriteLine(string.Join(" ", firstSet
                .Where(i => secondSet.Contains(i))));
        }
    }
}