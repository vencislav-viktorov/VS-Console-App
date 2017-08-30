using System;

namespace _10.Radians_to_Degrees
{
    class Radians_to_Degrees
    {
        static void Main()
        {
            Console.Write("radians = ");

            var radians = double.Parse(Console.ReadLine());

            var degrees = (radians * 180.0 / Math.PI);

            Console.Write("degrees = ");

            Console.WriteLine(degrees);
        }
    }
}
