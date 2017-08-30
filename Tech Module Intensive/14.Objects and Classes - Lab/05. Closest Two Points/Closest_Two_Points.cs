using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Closest_Two_Points
{
    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }

    public class Closest_Two_Points
    {
        public static void Main()
        {
            int numPoints = int.Parse(Console.ReadLine());

            Point[] points = new Point[numPoints];

            for (int i = 0; i < numPoints; i++)
                points[i] = ReadPoint();

            List<Point> closestPoints = new List<Point>();

            double minDistance = double.MaxValue;

            for (int i = 0; i < numPoints - 1; i++)
            {
                for (int j = i + 1; j < numPoints; j++)
                {
                    double currentDistance = CalcDistance(points[i], points[j]);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;

                        closestPoints.Clear();

                        closestPoints.Add(points[i]);

                        closestPoints.Add(points[j]);
                    }
                }
            }

            Console.WriteLine("{0:f3}", minDistance);

            foreach (var point in closestPoints)
                Console.WriteLine("({0}, {1})", point.X, point.Y);
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
                .Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Point point = new Point() { X = coordinates[0], Y = coordinates[1] };

            return point;
        }
    }
}
