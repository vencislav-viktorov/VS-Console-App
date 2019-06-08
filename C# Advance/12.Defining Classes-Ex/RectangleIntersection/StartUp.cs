﻿namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var rectangles = new List<Rectangle>();

            var inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputArray[0]; i++)
            {
                var rectangleInfo = Console.ReadLine()
                    .Split();

                rectangles.Add(new Rectangle(rectangleInfo[0],
                    double.Parse(rectangleInfo[1]), double.Parse(rectangleInfo[2]),
                    double.Parse(rectangleInfo[3]), double.Parse(rectangleInfo[4])));
            }

            for (int i = 0; i < inputArray[1]; i++)
            {
                var rectanglesIds = Console.ReadLine()
                    .Split();

                Console.WriteLine(Rectangle.AreTwoRectanglesInteracting(rectangles.Find(r => r.Id == rectanglesIds[0]), rectangles.Find(r => r.Id == rectanglesIds[1])));
            }
        }
    }
}