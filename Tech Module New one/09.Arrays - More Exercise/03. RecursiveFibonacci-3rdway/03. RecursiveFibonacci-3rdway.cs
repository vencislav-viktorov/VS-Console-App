using System;

namespace _03._RecursiveFibonacci_3rdway
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(number));
        }

        static int Fibonacci(int number)
        {
            int a = 0;
            int b = 1;

            if (number == 0)
            {
                return a;
            }

            for (int i = 2; i <= number; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}
