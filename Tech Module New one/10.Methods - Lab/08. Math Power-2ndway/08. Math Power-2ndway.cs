using System;

namespace _08._Math_Power_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(number, power));
        }

        static double RaiseToPower(double number, double power)
        {
            double saveNumber = number; 

            for (int i = 1; i < power; i++)
            {
                number *= saveNumber;
            }

            return number;
        }
    }
}
