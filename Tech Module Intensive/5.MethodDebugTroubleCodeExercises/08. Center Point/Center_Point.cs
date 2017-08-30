using System;

namespace _08.Center_Point
{
    public class Center_Point
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());

            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            if (PointCloserToCenter(x1, y1, x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }

            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static bool PointCloserToCenter(double x1, double y1, double x2, double y2)
        {
            var distance1 = CalculateDistanceBetweenPoints(x1, y1, 0, 0);

            var distance2 = CalculateDistanceBetweenPoints(x2, y2, 0, 0);

            if (distance1 < distance2)
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
