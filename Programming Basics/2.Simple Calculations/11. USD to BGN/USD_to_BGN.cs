using System;

namespace _11.USD_to_BGN
{
    class USD_to_BGN
    {
        static void Main()
        {
            Console.Write("USD = ");

            var USD = double.Parse(Console.ReadLine());

            var BGN = (USD * 1.7955);

            Console.Write("bgn = ");

            Console.WriteLine(BGN);
        }
    }
}
