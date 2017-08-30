using System;

namespace _08.House_Builder
{
    public class House_Builder
    {
        public static void Main()
        {
            long price1 = long.Parse(Console.ReadLine());

            long price2 = long.Parse(Console.ReadLine());

            long totalPrice = price1 > price2 ? price1 * 10 + price2 * 4 : price1 * 4 + price2 * 10;

            Console.WriteLine(totalPrice);
        }
    }
}
