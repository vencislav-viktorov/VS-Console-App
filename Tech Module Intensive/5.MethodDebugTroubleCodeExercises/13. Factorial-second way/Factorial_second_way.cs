using System;
using System.Numerics;

namespace _13.Factorial_second_way
{
    public class Factorial_second_way
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(Result(n));
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