using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(number));
        }

        static int Fibonacci(int number)
        {
            if (number <= 1)
            {
                return number;
            }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
