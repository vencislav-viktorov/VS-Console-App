using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                         .Split()
                         .Reverse()
                         .Select(int.Parse);

            int removeDivisible = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % removeDivisible != 0;

            Console.WriteLine(string.Join(" ", nums.Where(x => filter(x))));
        }
    }
}
