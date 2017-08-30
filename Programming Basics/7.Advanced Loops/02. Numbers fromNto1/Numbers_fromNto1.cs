using System;

namespace _02.Numbers_fromNto1
{
    class Numbers_fromNto1
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (var i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
