using System;

namespace _02._Circle_Area
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * r * r);
        }
    }
}
