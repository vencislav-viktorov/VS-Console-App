using System;

namespace _03.Exact_Product_of_Real_Numbers
{
    public class Exact_Product_of_Real_Numbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal product = 1;

            for (int i = 0; i < n; i++)
            {
                product *= decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(product);
        }
    }
}