using System;

namespace _1._Sort_Numbers_2nd_way
{
    public class Program
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int high = Math.Max(num1, Math.Max(num2, num3));
            int low = Math.Min(num1, Math.Min(num2, num3));
            int medium = num1 + num2 + num3 - high - low;

            Console.WriteLine(high);
            Console.WriteLine(medium);
            Console.WriteLine(low);

        }
    }
}
