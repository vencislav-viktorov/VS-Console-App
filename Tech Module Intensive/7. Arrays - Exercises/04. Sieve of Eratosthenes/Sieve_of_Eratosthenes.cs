using System;

namespace _04.Sieve_of_Eratosthenes
{
    public class Sieve_of_Eratosthenes
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
                    for (long p = 2; (p * j) <= n; p++)
                    {
                        primes[p * j] = false;
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
