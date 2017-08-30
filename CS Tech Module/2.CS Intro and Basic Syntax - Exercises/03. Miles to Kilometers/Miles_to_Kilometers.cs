using System;

namespace _03.Miles_to_Kilometers
{
    public class Miles_to_Kilometers
    {
        public static void Main()
        {
            double mile = double.Parse(Console.ReadLine());

            double sum = mile * 1.60934;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
