using System;

namespace _12._Even_Number_2nd_way
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                int number = Math.Abs(int.Parse(Console.ReadLine()));

                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {number}");
                    break;
                }

                Console.WriteLine("Please write an even number.");
            }
        }
    }
}
