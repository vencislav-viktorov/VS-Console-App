using System;

namespace _04.Photo_Gallery
{
    public class Photo_Gallery
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int day = int.Parse(Console.ReadLine());

            int month = int.Parse(Console.ReadLine());

            int year = int.Parse(Console.ReadLine());

            int hour = int.Parse(Console.ReadLine());

            int minutes = int.Parse(Console.ReadLine());

            double size = double.Parse(Console.ReadLine());

            int width = int.Parse(Console.ReadLine());

            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:d4}.jpg", number);

            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2} {3:d2}:{4:d2}",
                day, month, year, hour, minutes);

            if (size < 1000)
            {
                Console.WriteLine("Size: {0}B", size);
            }

            else if (size < 1000000)
            {
                size /= 1000;

                Console.WriteLine("Size: {0}KB", size);
            }

            else
            {
                size /= 1000000;

                Console.WriteLine("Size: {0}MB", size);
            }

            if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }

            else if (height > width)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }

            else if (height == width)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
        }
    }
}