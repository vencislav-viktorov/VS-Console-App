using System;
using System.Linq;

namespace _07.Largest_N_Elements
{
    public class Largest_N_Elements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var n = int.Parse(Console.ReadLine());

            numbers.Sort();

            numbers.Reverse();

            var result = numbers.Take(n);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
