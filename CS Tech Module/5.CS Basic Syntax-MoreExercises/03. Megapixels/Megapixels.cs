using System;

namespace _03.Megapixels
{
    public class Megapixels
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());

            var height = double.Parse(Console.ReadLine());

            double MP = ((width * height) / 1000000);

            Console.WriteLine("{0}x{1} => {2}MP", width, height, Math.Round(MP, 1));
        }
    }
}
