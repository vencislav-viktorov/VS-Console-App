using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal[]> orders = new Dictionary<string, decimal[]>();

            string inputLine = Console.ReadLine();

            while (inputLine != "buy")
            {
                string[] inputArray = inputLine.Split().ToArray();

                string product = inputArray[0];

                decimal price = decimal.Parse(inputArray[1]);

                decimal quantity = decimal.Parse(inputArray[2]);

                if (!orders.ContainsKey(product))
                {
                    orders.Add(product, new decimal[2]);
                }

                orders[product][0] = price;
                orders[product][1] += quantity;

                inputLine = Console.ReadLine();
            }

            foreach (var kvp in orders)
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value[0] * kvp.Value[1]):F2}");
            }
        }
    }
}
