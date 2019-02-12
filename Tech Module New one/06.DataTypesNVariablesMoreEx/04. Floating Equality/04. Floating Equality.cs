using System;

namespace _04._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            decimal difference = Math.Abs(num1 - num2);

            decimal epc = 0.000001m;

            if (difference < epc)
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
