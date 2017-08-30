using System;

namespace _09.Longer_Line
{
    public class Longer_Line
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());

            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());

            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var distance1 = CalculateDistanceBetweenPoints(x1, y1, x2, y2);

            var distance2 = CalculateDistanceBetweenPoints(x3, y3, x4, y4);


            if (distance1 > distance2)
            {
                if (PointIsCloserToCenter(x1, y1, x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }

                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }

            else
            {
                if (PointIsCloserToCenter(x3, y3, x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }

                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        static bool PointIsCloserToCenter(double x1, double y1, double x2, double y2)
        {
            var distance1 = CalculateDistanceBetweenPoints(x1, y1, 0, 0);

            var distance2 = CalculateDistanceBetweenPoints(x2, y2, 0, 0);

            if (distance1 <= distance2)
            {
                return true;
            }

            return false;
        }

        static double CalculateDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2)
                + Math.Pow(y2 - y1, 2));

            return distance;
        }
    }
}
