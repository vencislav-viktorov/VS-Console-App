﻿using System;
using System.Linq;

namespace _06.Rectangle_Position
{
    class Rectangle
    {
        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Right
        {
            get { return Left + Width; }
        }

        public int Bottom
        {
            get { return Top + Height; }
        }

        public bool IsInside(Rectangle r)
        {
            return r.Left <= Left && r.Top <= Top &&
                    r.Right >= Right && r.Bottom >= Bottom;
        }
    }

    public class Rectangle_Position
    {
        static void Main()
        {
            Rectangle rectangleA = ReadRectangle();

            Rectangle rectangleB = ReadRectangle();

            Console.WriteLine(rectangleA.IsInside(rectangleB) ? "Inside" : "Not inside");
        }

        private static Rectangle ReadRectangle()
        {
            int[] coordinates = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Rectangle rectangle = new Rectangle()
            {
                Left = coordinates[0],

                Top = coordinates[1],

                Width = coordinates[2],

                Height = coordinates[3]
            };

            return rectangle;
        }
    }
}
