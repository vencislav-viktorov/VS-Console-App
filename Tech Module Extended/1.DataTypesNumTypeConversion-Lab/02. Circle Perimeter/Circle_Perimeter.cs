using System;

namespace _02.Circle_Perimeter
{
    public class Circle_Perimeter
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f12}", 2 * Math.PI * r);
        }
    }
}