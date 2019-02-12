using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());

            BigInteger num2 = BigInteger.Parse(Console.ReadLine());

            BigInteger miltiply = num1 * num2;

            Console.WriteLine(miltiply);
        }
    }
}
