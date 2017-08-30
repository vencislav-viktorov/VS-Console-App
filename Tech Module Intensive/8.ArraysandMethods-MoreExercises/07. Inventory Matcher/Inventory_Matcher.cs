using System;
using System.Linq;

namespace _07.Inventory_Matcher
{
    public class Inventory_Matcher
    {
        public static void Main()
        {
            var goodsList = Console.ReadLine()
                .Split(' ')
                .ToList();

            var quantities = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            var prices = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            var command = Console.ReadLine();

            while (command != "done")
            {
                int indexOfGoods = goodsList.IndexOf(command);

                Console.WriteLine(
                    $"{goodsList[indexOfGoods]} " +
                    $"costs: {prices[indexOfGoods]}; " +
                    $"Available quantity: {quantities[indexOfGoods]}"
                    );

                command = Console.ReadLine();
            }
        }
    }
}
