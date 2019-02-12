using System;

namespace _02._Division
{
    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            int division = 0;

            if (number % 2 == 0)
            {
                division = 2;
            }

            if (number % 3 == 0)
            {
                division = 3;
            }

            if (number % 6 == 0)
            {
                division = 6;
            }

            if (number % 7 == 0)
            {
                division = 7;
            }

            if (number % 10 == 0)
            {
                division = 10;
            }

            if (division == 0)
            {
                Console.WriteLine("Not divisible");
            }

            else
            {
                Console.WriteLine($"The number is divisible by {division}");
            }
        }
    }
}
