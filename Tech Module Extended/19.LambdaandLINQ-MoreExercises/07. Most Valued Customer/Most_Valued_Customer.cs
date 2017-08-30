using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Most_Valued_Customer
{
    public class MostValuedCustomer
    {
        static Dictionary<string, double> products = new Dictionary<string, double>();

        static Dictionary<string, Dictionary<string, double>> users =
            new Dictionary<string, Dictionary<string, double>>();

        public static void Main()
        {
            UntillShopIsClosedReadFrom(Console.ReadLine());

            ReadComandsUntillPrintFrom(Console.ReadLine());

            CalculateAllProductsByGivenPrice();

            PrintWhoIsBiggerSpender();
        }

        static void PrintWhoIsBiggerSpender()
        {
            var biggerSpender = TakeBiggerSpender();

            Console.WriteLine($"Biggest spender: {biggerSpender.First().Key}");

            Console.WriteLine($"^Products bought:");

            foreach (var user in biggerSpender)
            {
                foreach (var item in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"^^^{item.Key}: {item.Value:F2}");
                }
            }

            var totalSum = users.OrderByDescending(x => x.Value.Values.Sum()).First().Value.Values.Sum();

            Console.WriteLine($"Total: {totalSum:F2}");

        }

        static Dictionary<string, Dictionary<string, double>> TakeBiggerSpender()
        {
            var bigger = new Dictionary<string, Dictionary<string, double>>();

            var user = string.Empty;

            foreach (var item in users.OrderByDescending(x => x.Value.Values.Sum()))
            {
                user = item.Key;

                break;
            }

            bigger[user] = new Dictionary<string, double>();

            foreach (var item in users.OrderByDescending(x => x.Value.Values.Sum()).First().Value)
            {
                bigger[user][item.Key] = products[item.Key];
            }

            return bigger;
        }

        static void CalculateAllProductsByGivenPrice()
        {
            var userKeys = users.Keys.ToArray();

            for (int i = 0; i < userKeys.Length; i++)
            {
                var valueKeys = users[userKeys[i]].Keys.ToArray();

                CalculateCurentUser(userKeys[i], valueKeys);
            }
        }

        static void CalculateCurentUser(string name, string[] product)
        {
            for (int i = 0; i < product.Length; i++)
            {
                users[name][product[i]] *= products[product[i]];
            }
        }

        static void UntillShopIsClosedReadFrom(string unsplited)
        {
            if (unsplited != "Shop is open")
            {
                SplitAndAddToProductCollection(unsplited);

                UntillShopIsClosedReadFrom(Console.ReadLine());
            }

            else return;
        }

        static void SplitAndAddToProductCollection(string unsplited)
        {
            var splited = unsplited.Split();

            var productName = splited.First();

            var productPrice = Convert.ToDouble(splited.Last());

            ProductsAdd(productName, productPrice);
        }

        static void ProductsAdd(string productName, double productPrice)
        {
            if (!products.ContainsKey(productName))
            {
                products[productName] = 0;
            }

            products[productName] = productPrice;
        }

        static void ReadComandsUntillPrintFrom(string unsplited)
        {
            if (unsplited != "Print")
            {
                if (unsplited == "Discount")
                {
                    DecreaseFirstThreeExpensive();
                }

                else
                {
                    SplitAndAddToUsers(unsplited);
                }

                ReadComandsUntillPrintFrom(Console.ReadLine());
            }

            else return;
        }

        static void DecreaseFirstThreeExpensive()
        {
            var expensives = TakeFirstThree();

            for (int index = 0; index < expensives.Length; index++)
            {
                var key = expensives[index];

                products[key] = products[key] * 0.9;
            }
        }

        static string[] TakeFirstThree()
        {
            products = products.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return products.Keys.Take(3).ToArray();
        }

        static void SplitAndAddToUsers(string unsplited)
        {
            var splited = unsplited.Split(new[] { ": ", ", " }, 
                StringSplitOptions.RemoveEmptyEntries);

            var name = splited.First();

            var products = splited.Skip(1).ToArray();

            UsersAdd(name, products);
        }

        static void UsersAdd(string name, string[] collection)
        {
            if (!users.ContainsKey(name))
            {
                users[name] = new Dictionary<string, double>();
            }

            foreach (var item in collection)
            {
                if (products.ContainsKey(item))
                {
                    if (!users[name].ContainsKey(item))
                    {
                        users[name][item] = 0;
                    }

                    users[name][item]++;
                }
            }
        }
    }
}
