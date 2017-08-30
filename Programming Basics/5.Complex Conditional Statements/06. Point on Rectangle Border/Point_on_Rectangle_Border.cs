using System;

namespace _06.Point_on_Rectangle_Border
{
    class Point_on_Rectangle_Border
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());

            var y1 = double.Parse(Console.ReadLine());

            var x2 = double.Parse(Console.ReadLine());

            var y2 = double.Parse(Console.ReadLine());

            var x = double.Parse(Console.ReadLine());

            var y = double.Parse(Console.ReadLine());

            if (((x == x1 || x == x2) && y >= y1 && y <= y2) ||
                ((y == y1 || y == y2) && x >= x1 && x <= x2))
            {
                Console.WriteLine("Border");
            }

            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
