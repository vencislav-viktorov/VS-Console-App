namespace PointInRectangle
{
    using System;
    using System.Linq;

    public class PointInRectangle
    {
        public static void Main()
        {
            var cordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var topLeft = new Point(cordinates[0], cordinates[1]);
            var bottomRight = new Point(cordinates[2], cordinates[3]);
            var rectangle = new Rectangle(topLeft, bottomRight);

            int lineCounts = int.Parse(Console.ReadLine());

            for (int line = 0; line < lineCounts; line++)
            {
                cordinates = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                var point = new Point(cordinates[0], cordinates[1]);
                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}
