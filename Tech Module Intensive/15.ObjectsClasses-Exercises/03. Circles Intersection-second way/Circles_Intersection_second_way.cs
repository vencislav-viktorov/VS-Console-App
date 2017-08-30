using System;
using System.Linq;

namespace _03.Circles_Intersection_second_way
{
    class Circles_Intersection_second_way
    {
        static void Main(string[] args)
        {
            Circle one = GetCircle();

            Circle two = GetCircle();

            double distance = GetDistance(one.Point, two.Point);

            if (distance <= one.R + two.R)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }

        }


        public static double GetDistance(Point point1, Point point2)
        {
            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

            return distance;
        }

        public static Circle GetCircle()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point = new Point() { X = input[0], Y = input[1] };

            Circle circle = new Circle() { Point = point, R = input[2] };

            return circle;

        }
    }

    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }

    class Circle
    {
        public Point Point { get; set; }

        public int R { get; set; }
    }
}