using System;
using System.Linq;

namespace _02.Smallest_Element_in_Array
{
    public class Smallest_Element_in_Array
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                  .Split(new char[] { ' ' },
                  StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            var smallestNumber = numbers.Min();

            Console.WriteLine(smallestNumber);
        }
    }
}
