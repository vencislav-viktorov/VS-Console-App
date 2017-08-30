using System;
using System.Linq;

namespace _01.Array_Contains_Element
{
    public class Array_Contains_Element
    {
        public static void Main()
        {
            var number = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var n = int.Parse(Console.ReadLine());

            var contain = number.Contains(n);

            if (contain)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
