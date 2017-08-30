using System;
using System.Linq;

namespace _02.Largest_3_Numbers
{
    public class Largest_3_Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = numbers.OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
