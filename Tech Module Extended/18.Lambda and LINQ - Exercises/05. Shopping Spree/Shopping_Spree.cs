using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Shopping_Spree
{
    public class ShoppingSpree
    {
        static double price = 0;

        static string product = string.Empty;

        static Dictionary<string, double> mealProductsCollection = new Dictionary<string, double>();

        public static void Main()
        {
            var moneyToSpend = Convert.ToDouble(Console.ReadLine());

            ReadNextProductUntillEnds(Console.ReadLine());

            if (AreMoneyEnought(moneyToSpend))
            {
                PrintAllProductsInGivenOrder();

                return;
            }

            Console.WriteLine("Need more money... Just buy banichka");
        }

        private static void ReadNextProductUntillEnds(string productsWithPrice)
        {
            if (productsWithPrice != "end")
            {
                ParseProductsAndTheirPricesFrom(productsWithPrice);

                AddOrUpdateCurrentProductToMealProductsCollection();

                ReadNextProductUntillEnds(Console.ReadLine());
            }

            else return;
        }

        static void ParseProductsAndTheirPricesFrom(string productsWithPrice)
        {
            var splitedProducts = productsWithPrice.Split(' ');

            price = Convert.ToDouble(splitedProducts[1]);

            product = splitedProducts[0];
        }

        static void AddOrUpdateCurrentProductToMealProductsCollection()
        {
            if (mealProductsCollection.ContainsKey(product))
            {
                UpdateCurrentPrice();

                return;
            }

            if (!mealProductsCollection.ContainsKey(product))
            {
                mealProductsCollection[product] = 0;
            }

            mealProductsCollection[product] = price;
        }

        static void UpdateCurrentPrice()
        {
            var oldPrice = mealProductsCollection[product];

            if (oldPrice > price)
            {
                mealProductsCollection[product] = price;
            }

            else mealProductsCollection[product] = oldPrice;
        }

        private static bool AreMoneyEnought(double moneyToSpend)
        {
            return mealProductsCollection.Values.Sum() <= moneyToSpend;
        }

        private static void PrintAllProductsInGivenOrder()
        {
            foreach (var product in mealProductsCollection
                .OrderByDescending(x => x.Value).ThenBy(x => x.Key.Length))
            {
                Console.WriteLine($"{product.Key} costs {product.Value:F2}");
            }
        }
    }
}
