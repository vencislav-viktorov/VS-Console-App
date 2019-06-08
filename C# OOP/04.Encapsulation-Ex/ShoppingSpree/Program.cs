namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var persons = new List<Person>();
            var products = new List<Product>();

            var peopleAndTheirMoney = Console.ReadLine()
                .Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var currentPerson in peopleAndTheirMoney)
            {
                var tokens = currentPerson
                    .Split("=");
                var name = tokens[0].Trim();
                var money = decimal.Parse(tokens[1].Trim());

                try
                {
                    persons.Add(new Person(name, money));
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            var productsAndCost = Console.ReadLine()
                .Split(new char[] { ';', ' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var currentProduct in productsAndCost)
            {
                var tokens = currentProduct
                    .Split("=");
                var nameOfProduct = tokens[0].Trim();
                var costOfProduct = decimal.Parse(tokens[1].Trim());

                try
                {
                    products.Add(new Product(nameOfProduct, costOfProduct));
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var splitedInput = input
                    .Split();

                var personName = splitedInput[0];
                var purchase = splitedInput[1];

                var person = persons
                    .Where(p => p.Name == personName)
                    .First();
                var product = products
                    .Where(p => p.Name == purchase)
                    .First();

                if (person.Money >= product.Money)
                {
                    person.Money -= product.Money;
                    person.AddProductToBag(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }

                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
            }

            foreach (var person in persons)
            {
                if (person.SeeBag().Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.SeeBag().Select(p => p.Name))}");
                }

                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
