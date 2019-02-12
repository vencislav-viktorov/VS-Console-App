using System;

namespace _05._PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 2; num <= n; num++)
            {
                bool isPrime = true;

                for (int divisor = 2; divisor < num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{num} -> {isPrime.ToString().ToLower()}");
            }

        }
    }
}
