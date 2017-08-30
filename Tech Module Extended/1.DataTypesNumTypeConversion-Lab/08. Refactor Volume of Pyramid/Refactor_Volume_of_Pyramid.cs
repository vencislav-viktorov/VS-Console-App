using System;

namespace _08.Refactor_Volume_of_Pyramid
{
    public class Refactor_Volume_of_Pyramid
    {
        public static void Main()
        {
            Console.Write("Length: ");

            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");

            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");

            double height = double.Parse(Console.ReadLine());

            double pyramidVolume = (height * width * length) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", pyramidVolume);
        }
    }
}