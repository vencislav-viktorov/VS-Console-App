using System;

namespace _05.Trapeziod_Area
{
    class Trapeziod_Area
    {
        static void Main()
        {
            Console.WriteLine("b1 = ");

            Console.WriteLine("b2 = ");

            Console.WriteLine("h = ");

            var b1 = double.Parse(Console.ReadLine());

            var b2 = double.Parse(Console.ReadLine());

            var h = double.Parse(Console.ReadLine());

            var area = (b1 + b2) * h / 2;

            Console.Write("Trapezoid = ");

            Console.WriteLine(area);
        }
    }
}
