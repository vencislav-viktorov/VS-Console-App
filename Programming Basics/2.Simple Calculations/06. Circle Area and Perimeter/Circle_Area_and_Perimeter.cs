using System;

namespace _06.Circle_Area_and_Perimeter
{
    class Circle_Area_and_Perimeter
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;

            double perimeter = 2 * Math.PI * r;

            Console.WriteLine("area = {0}/nperimeter = {1}", 
                area, 
                perimeter);
        }
    }
}
