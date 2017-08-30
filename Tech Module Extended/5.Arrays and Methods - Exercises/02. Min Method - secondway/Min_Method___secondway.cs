using System;

namespace _02.Min_Method___secondway
{
    public class Min_Method___secondway
    {
        public static void Main()
        {
            long num1 = long.Parse(Console.ReadLine());

            long num2 = long.Parse(Console.ReadLine());

            long num3 = long.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(num1, GetMin(num2, num3)));
        }

        static long GetMin(long num1, long num2)
        {
            return Math.Min(num1, num2);
        }
    }
}
