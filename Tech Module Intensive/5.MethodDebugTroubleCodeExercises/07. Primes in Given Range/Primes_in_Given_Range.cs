using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    public class Primes_in_Given_Range
    {
        public static void Main()
        {
            var startNum = int.Parse(Console.ReadLine());

            var endNum = int.Parse(Console.ReadLine());

            var primesInRange = FindPrimesInRange(startNum, endNum);

            Console.WriteLine(string.Join(", ", primesInRange));
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();

            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }

            return primes;
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
