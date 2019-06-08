using System;
using System.Numerics;

namespace Factorial
{
    public class Program
    {
        public static void Main()
        {
            var number = BigInteger.Parse(Console.ReadLine());
            var result = Factorial(number);
            Console.WriteLine(result);
        }

        public static BigInteger Factorial(BigInteger number)
        {
            if (number < 0)
            {
                throw new InvalidOperationException();
            }

            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}
