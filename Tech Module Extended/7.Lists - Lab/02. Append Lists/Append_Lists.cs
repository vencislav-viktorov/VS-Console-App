using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Append_Lists
{
    public class Append_Lists
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split('|')
                .ToList();

            var result = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                var index = numbers[i]
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                index.Reverse();

                foreach (var num in index)
                {
                    result.Add(num);
                }
            }

            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
