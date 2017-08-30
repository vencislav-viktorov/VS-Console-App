using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Boxes
{
    public class Box
    {
        public int X1 { get; set; }

        public int X2 { get; set; }

        public int Y1 { get; set; }

        public int Y2 { get; set; }

        public static int Height(int Y1, int Y2)
        {
            var height = Math.Abs(Y1 - Y2);

            return height;
        }

        public static int Widht(int X1, int X2)
        {
            var widht = Math.Abs(X1 - X2);

            return widht;
        }
    }

    public class Boxes
    {
        public static void Main()
        {
            var enter = Console.ReadLine();

            var boxes = new List<Box>();

            while (enter != "end")
            {
                var cordinates = enter.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                var p1 = cordinates[0].Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                var p2 = cordinates[1].Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                var p3 = cordinates[2].Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                var box = new Box();
                {
                    box.X1 = int.Parse(p1[0]);

                    box.X2 = int.Parse(p2[0]);

                    box.Y1 = int.Parse(p2[1]);

                    box.Y2 = int.Parse(p3[1]);
                }

                boxes.Add(box);

                enter = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                var widht = Box.Widht(box.X1, box.X2);

                var height = Box.Height(box.Y1, box.Y2);

                Console.WriteLine($"Box: {widht}, {height}");

                Console.WriteLine($"Perimeter: {(widht + height) * 2}");

                Console.WriteLine($"Area: {widht * height}");
            }
        }
    }
}
