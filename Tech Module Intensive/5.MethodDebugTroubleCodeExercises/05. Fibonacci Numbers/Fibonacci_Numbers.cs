using System;

namespace _05.Fibonacci_Numbers
{
    public class Fibonacci_Numbers
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(n));

        }

        static long Fibonacci(long n)
        {
            long startFibNum = 1;

            long sum = 0;

            for (int i = 0; i <= n; i++)
            {
                long preemption = sum;

                sum += startFibNum;

                startFibNum = preemption;
            }

            return sum;
        }
    }
}
