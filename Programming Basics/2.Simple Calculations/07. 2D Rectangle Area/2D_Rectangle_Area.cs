using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._2D_Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());

            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());

            double y2 = double.Parse(Console.ReadLine());

            var a = Math.Abs(x1 - x2);

            var b = Math.Abs(y1 - y2);

            Console.WriteLine(a * b);

            Console.WriteLine((a + b) * 2);
        }
    }
}
