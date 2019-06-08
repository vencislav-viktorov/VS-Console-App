using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Print_Even_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToList();

            Stack<int> stack = new Stack<int>(numbers);

            var result = stack
                .Where(x => x % 2 == 0)
                .ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
