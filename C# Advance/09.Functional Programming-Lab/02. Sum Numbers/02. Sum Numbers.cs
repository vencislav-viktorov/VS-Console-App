using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Func<string, int> parser = int.Parse;

            int[] numbers = input.Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}
