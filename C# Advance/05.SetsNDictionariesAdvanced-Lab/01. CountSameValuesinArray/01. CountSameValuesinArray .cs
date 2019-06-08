using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountSameValuesinArray
{
    class Program
    {
        static void Main()
        {
            double[] nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var counts = new Dictionary<double, int>();

            foreach (var num in nums)
            {
                if (counts.ContainsKey(num) == false)
                {
                    counts[num] = 0;
                }

                counts[num]++;
            }

            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
