using System;
using System.Numerics;

namespace _14.FactorialTrailZero_secondway
{
    public class FactorialTrailZero_secondway
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger factorial = Result(n);

            int zeroes = TrailingZeroesCount(factorial);

            Console.WriteLine(zeroes);
        }

        static int TrailingZeroesCount(BigInteger factorial)
        {
            int zeroes = 0;

            bool hasZeroes = true;

            while (hasZeroes == true)
            {
                BigInteger digit = factorial % 10;

                factorial /= 10;

                if (digit == 0)
                {
                    zeroes++;
                }

                else
                {
                    hasZeroes = false;
                }
            }

            return zeroes;
        }

        static BigInteger Result(int n)
        {
            BigInteger factorial = 1;

            while (n > 1)
            {
                factorial *= n;

                n--;
            }

            return factorial;
        }
    }
}