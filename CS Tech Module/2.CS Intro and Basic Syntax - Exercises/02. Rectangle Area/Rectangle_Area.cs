using System;

namespace _02.Rectangle_Area
{
    public class Rectangle_Area
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());

            double sum = width * height;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
