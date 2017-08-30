using System;

namespace _06.Math_Power
{
    public class Math_Power
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            double power = double.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);

            Console.WriteLine(result);
        }

        static double RaiseToPower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
