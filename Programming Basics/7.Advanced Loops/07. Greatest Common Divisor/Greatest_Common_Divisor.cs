using System;

namespace _07.Greatest_Common_Divisor
{
    class Greatest_Common_Divisor
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());

            var b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                var oldB = b;

                b = a % b;

                a = oldB;
            }

            Console.WriteLine("CGD = {0}", a);
        }
    }
}
