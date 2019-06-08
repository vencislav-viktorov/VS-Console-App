using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main()
        {
            var shopsProductsAndPrices = new Dictionary<string, Dictionary<string, double>>();
            var input = Console.ReadLine();

            while (input != "Revision")
            {
                var tokens = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var shop = tokens[0];
                var product = tokens[1];
                var price = double.Parse(tokens[2]);

                if (shopsProductsAndPrices.ContainsKey(shop) == false)
                {
                    shopsProductsAndPrices[shop] = new Dictionary<string, double>();
                }

                shopsProductsAndPrices[shop][product] = price;

                input = Console.ReadLine();
            }

            foreach (var shop in shopsProductsAndPrices.OrderBy(x => x.Key))
            {
                var currentShop = shop.Key;
                Console.WriteLine($"{currentShop}->");

                foreach (var product in shop.Value)
                {
                    var currentProduct = product.Key;
                    var priceForProduct = product.Value;
                    Console.WriteLine($"Product: {currentProduct}, Price: {priceForProduct}");
                }
            }
        }
    }
}