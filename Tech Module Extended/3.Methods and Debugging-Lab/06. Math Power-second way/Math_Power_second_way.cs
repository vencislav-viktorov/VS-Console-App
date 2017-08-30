using System;

namespace _06.Math_Power_second_way
{
    public class Math_Power_second_way
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);

            Console.WriteLine(result);
        }

        static double RaiseToPower(double number, int power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
