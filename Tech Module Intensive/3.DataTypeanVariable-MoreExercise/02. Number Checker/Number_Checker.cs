using System;

namespace _02.Number_Checker
{
    public class Number_Checker
    {
        public static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());

            if (number % 1 == 0)
            {
                Console.WriteLine("integer");
            }

            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
