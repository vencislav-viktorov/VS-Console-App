using System;
using System.Linq;

namespace _03.Reverse_Array_In_place
{
    public class Reverse_Array_In_place
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }
    }
}
