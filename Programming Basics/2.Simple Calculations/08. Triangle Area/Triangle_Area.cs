using System;

namespace _08.Triangle_Area
{
    class Triangle_Area
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());

            double h = double.Parse(Console.ReadLine());

            double area = a * h / 2;

            Console.WriteLine("Triangle area = {0}", area);
        }
    }
}
