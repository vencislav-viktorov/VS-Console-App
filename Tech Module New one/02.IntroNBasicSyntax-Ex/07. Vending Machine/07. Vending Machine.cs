using System;

namespace _07._Vending_Machine
{
    public class Program
    {
        public static void Main()
        {
            decimal totalMoney = 0;

            while (true)
            {
                string money = Console.ReadLine().ToLower();

                if (money == "start")
                {
                    break;
                }

                decimal coin = decimal.Parse(money);

                if (coin == 0.1m || coin == 0.2m || coin == 0.5m
                    || coin == 1m || coin == 2m)
                {
                    totalMoney += coin;
                }

                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }

            while (true)
            {
                string product = Console.ReadLine().ToLower();

                if (product == "end")
                {
                    break;
                }

                if (product == "nuts")
                {
                    if (totalMoney < 2)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }

                    Console.WriteLine($"Purchased {product}");
                    totalMoney -= 2;
                }

                else if (product == "water")
                {
                    if (totalMoney < 0.7m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }

                    Console.WriteLine($"Purchased {product}");
                    totalMoney -= 0.7m;
                }

                else if (product == "crisps")
                {
                    if (totalMoney < 1.5m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }

                    Console.WriteLine($"Purchased {product}");
                    totalMoney -= 1.5m;
                }

                else if (product == "soda")
                {
                    if (totalMoney < 0.8m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }

                    Console.WriteLine($"Purchased {product}");
                    totalMoney -= 0.8m;
                }

                else if (product == "coke")
                {
                    if (totalMoney < 1m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }

                    Console.WriteLine($"Purchased {product}");
                    totalMoney -= 1m;
                }

                else
                {
                    Console.WriteLine("Invalid product");
                }
            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
