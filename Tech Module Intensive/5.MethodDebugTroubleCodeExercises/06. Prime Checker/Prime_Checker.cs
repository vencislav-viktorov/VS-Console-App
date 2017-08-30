using System;

namespace _06.Prime_Checker
{
    public class Prime_Checker
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(n);

            Console.WriteLine(isPrime);
        }

        static bool IsPrime(long n)
        {
            var isPrime = true;

            if (n == 0 || n == 1)
            {
                isPrime = false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
