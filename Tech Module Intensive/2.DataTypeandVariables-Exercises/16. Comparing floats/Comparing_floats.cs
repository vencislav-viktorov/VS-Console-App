using System;

namespace _16.Comparing_floats
{
    public class Comparing_floats
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());

            double b = double.Parse(Console.ReadLine());

            double difference = Math.Abs(a - b);

            const double precision = 0.000001;

            if (difference < precision)
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