using System;

namespace _04.Sieve_of_Eratosthenes_second_way
{
    public class Sieve_of_Eratosthenes_second_way
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }
 
            for (int j = 2; j <= n; j++)
            {
                if (primes[j])
                {
                    for (long p = 2 * j; p <= n; p += j)
                    {
                        primes[p] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
