using System;

namespace _11.Odd_Number
{
    public class Odd_Number
    {
        public static void Main()
        {
            short number = Math.Abs(short.Parse(Console.ReadLine()));

            bool isEven = number % 2 == 0;

            while (isEven)
            {
                Console.WriteLine("Please write an odd number.");

                number = Math.Abs(short.Parse(Console.ReadLine()));

                isEven = number % 2 == 0;
            }

            Console.WriteLine($"The number is: {number}");
        }
    }
}
