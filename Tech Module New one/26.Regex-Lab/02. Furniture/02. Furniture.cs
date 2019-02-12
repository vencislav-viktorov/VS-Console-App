﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @">>(\w+)<<(\d+.?\d*)!(\d+)";

            var products = new List<string>();

            decimal totalPrice = 0.0m;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    Console.WriteLine("Bought furniture:");

                    foreach (var item in products)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine($"Total money spend: {totalPrice:F2}");
                    break;
                }

                Match matchedProduct = Regex.Match(input, regex);

                if (matchedProduct.Groups[1].Value == string.Empty)
                {
                    continue;
                }

                if (matchedProduct.Groups[2].Value == string.Empty)
                {
                    continue;
                }

                if (matchedProduct.Groups[3].Value == string.Empty)
                {
                    continue;
                }

                string product = matchedProduct.Groups[1].Value;

                decimal price = decimal.Parse(matchedProduct.Groups[2].Value);

                int quantity = int.Parse(matchedProduct.Groups[3].Value);

                products.Add(product);

                totalPrice += (price * quantity);
            }
        }
    }
}
