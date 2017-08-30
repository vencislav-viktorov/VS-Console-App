using System;

namespace _11.Geometry_Calculator
{
    public class Geometry_Calculator
    {
        public static void Main()
        {
            string figure = Console.ReadLine();

            GeometricFigureSelector(figure);
        }

        static void GeometricFigureSelector(string figure)
        {
            switch (figure)
            {
                case "triangle":
                    TriangleCalculator();
                    break;

                case "square":
                    SquareCalculator();
                    break;

                case "rectangle":
                    RectangleCalculator();
                    break;

                case "circle":
                    CircleCalculator();
                    break;
            }
        }

        static void TriangleCalculator()
        {
            double side = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());

            double area = side * height / 2;

            Console.WriteLine($"{area:F2}");
        }

        static void SquareCalculator()
        {
            double side = double.Parse(Console.ReadLine());

            double area = Math.Pow(side, 2);

            Console.WriteLine($"{area:F2}");
        }

        static void RectangleCalculator()
        {
            double width = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());

            double area = width * height;

            Console.WriteLine($"{area:F2}");
        }

        static void CircleCalculator()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"{area:F2}");
        }
    }
}