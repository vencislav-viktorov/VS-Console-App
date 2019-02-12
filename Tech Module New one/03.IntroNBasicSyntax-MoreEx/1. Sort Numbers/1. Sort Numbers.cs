using System;
using System.Linq;

namespace _1._Sort_Numbers
{
    public class Program
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int min = Math.Min(num1, Math.Min(num2, num3));
            int max = Math.Max(num1, Math.Max(num2, num3));
            int middle = 0;

            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    middle = num2;
                }
                else if (num3 > num1)
                {
                    middle = num1;
                }
                else
                {
                    middle = num3;
                }
            }
            else
            {
                if (num2 < num3)
                {
                    middle = num2;
                }
                else if (num3 < num1)
                {
                    middle = num1;
                }
                else
                {
                    middle = num3;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(middle);
            Console.WriteLine(min);
        }
    }
}
