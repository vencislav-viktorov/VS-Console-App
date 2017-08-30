using System;

namespace _02.Sign_of_Integer_Number
{
    public class Sign_of_Integer_Number
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintSign(n);
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }

            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }

            else
            {
                Console.WriteLine("The number {0} is zero.", number);
            }
        }

    }
}