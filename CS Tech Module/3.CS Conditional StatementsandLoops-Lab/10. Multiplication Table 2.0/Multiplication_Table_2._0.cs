using System;

namespace _10.Multiplication_Table_2._0
{
    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var multiplier = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");

                multiplier++;
            }

            while (multiplier <= 10);
        }
    }
}
