using System;

namespace _07.From_Terabytes_to_Bits
{
    public class From_Terabytes_to_Bits
    {
        public static void Main()
        {
            var n = double.Parse(Console.ReadLine());

            double sum = n * 1024 * 1024 * 1024 * 1024 * 8;

            Console.WriteLine(sum);
        }
    }
}