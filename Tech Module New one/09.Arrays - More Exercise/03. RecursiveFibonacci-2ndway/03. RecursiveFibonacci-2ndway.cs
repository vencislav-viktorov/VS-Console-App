using System;

namespace _03._RecursiveFibonacci_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(FibonacciNumber(number));
        }

        static int FibonacciNumber(int number)
        {
            int[] fibonacci = new int[number + 1];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            return fibonacci[number];
        }
    }
}
