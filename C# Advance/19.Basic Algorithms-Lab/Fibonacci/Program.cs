using System;
using System.Numerics;

namespace Fibonacci
{
    public class Program
    {
        private static BigInteger[] cache;

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            cache = new BigInteger[number + 1];

            var result = Fibonacci(number);
            Console.WriteLine(result);
        }

        public static BigInteger Fibonacci(int number)
        {
            if (cache[number] != 0)
            {
                return cache[number];
            }

            if (number == 1 || number == 2)
            {
                return 1;
            }

            var result = Fibonacci(number - 1) + Fibonacci(number - 2);
            cache[number] = result;
            return result;
        }
    }
}
