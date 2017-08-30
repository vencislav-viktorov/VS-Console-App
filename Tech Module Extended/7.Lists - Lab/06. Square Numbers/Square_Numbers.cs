using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Square_Numbers
{
    public class Square_Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var square = Math.Sqrt(numbers[i]);

                if (square == (int)square)
                {
                    result.Add(numbers[i]);
                }
            }

            result.Sort();

            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
