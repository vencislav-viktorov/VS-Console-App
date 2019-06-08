using System;
using System.Linq;

namespace _01._SortEvenNumbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToList();

            var result = string.Join(", ", numbers);
            Console.WriteLine(result);
        }
    }
}
