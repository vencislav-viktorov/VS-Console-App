using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Square_Numbers
{
    public class Square_Numbers
    {
        public static void Main()
        {
            List<int> lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> solution = new List<int>();

            for (int cycle = 0; cycle < lineOfDigits.Count; cycle++)
            {
                if (Math.Sqrt(lineOfDigits[cycle]) == (int)Math.Sqrt(lineOfDigits[cycle]))
                {
                    solution.Add(lineOfDigits[cycle]);
                }
            }

            solution.Sort();

            solution.Reverse();

            Console.WriteLine(string.Join(" ", solution));
        }
    }
}
