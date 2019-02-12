using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());

            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(Factorial(num1)/Factorial(num2)):f2}");
        }

        static double Factorial(double number)
        {
            double factorial = number;

            for (int i = 2; i < number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
