using System;

namespace _02.Inches_to_Centimeters
{
    class Inches_to_Centimeters
    {
        static void Main()
        {
            Console.Write("inch = ");

            var inch = double.Parse(Console.ReadLine());

            var sm = inch * 2.54;

            Console.Write("sm = ");

            Console.WriteLine(sm);
        }
    }
}
