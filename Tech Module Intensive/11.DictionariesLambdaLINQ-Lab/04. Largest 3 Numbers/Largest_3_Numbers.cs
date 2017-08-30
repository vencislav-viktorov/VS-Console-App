using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest_3_Numbers
{
    public class Largest_3_Numbers
    {
        public static void Main()
        {
            List<int> lineOfDigits = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", lineOfDigits));
        }
    }
}
