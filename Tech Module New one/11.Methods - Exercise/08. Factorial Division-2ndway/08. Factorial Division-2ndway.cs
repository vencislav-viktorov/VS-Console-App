using System;

namespace _08._Factorial_Division_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());

            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(Factorial(num1) / Factorial(num2)):f2}");
        }

        static double Factorial(double number)
        {
            if (number <= 1)
            {
                return 1;
            }

            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
