using System;

namespace _04._ConvertMeters2Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double convertToKm = meters / 1000;
            Console.WriteLine($"{convertToKm:f2}");
        }
    }
}
