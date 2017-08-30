using System;

namespace _01.Square_Area
{
    class Square_Area
    {
        static void Main()
        {
            Console.Write("a = ");

            var a = int.Parse(Console.ReadLine());

            var area = a * a;

            Console.Write("Square = ");

            Console.WriteLine(area);
        }
    }
}
