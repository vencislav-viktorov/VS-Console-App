using System;

namespace _06.Interval_of_Numbers
{
    public class Interval_of_Numbers
    {
        public static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());

            var num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.WriteLine(i);
                }
            }

            if (num1 > num2)
            {
                for (int i = num2; i <= num1; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
