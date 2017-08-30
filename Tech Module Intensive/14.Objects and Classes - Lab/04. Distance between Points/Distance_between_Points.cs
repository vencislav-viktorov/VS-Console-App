using System;
using System.Linq;

namespace _04.Distance_between_Points
{
    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }

    public class Distance_between_Points
    {
        public static void Main()
        {
            Point pointA = ReadPoint();

            Point pointB = ReadPoint();

            double distanceBetweenPoints = CalcDistance(pointA, pointB);

            Console.WriteLine("{0:f3}", distanceBetweenPoints);
        }

        private static double CalcDistance(Point pointA, Point pointB)
        {
            int deltaX = Math.Abs(pointA.X - pointB.X);

            int deltaY = Math.Abs(pointA.Y - pointB.Y);

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        private static Point ReadPoint()
        {
            int[] coordinates = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Point point = new Point() { X = coordinates[0], Y = coordinates[1] };

            return point;
        }
    }
}
