using System;

namespace _06.Prime_Checker__second_way
{
    public class Prime_Checker__second_way
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
                isPrime = !isPrime;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = !isPrime;
                }
            }

            return isPrime;
        }
    }
}