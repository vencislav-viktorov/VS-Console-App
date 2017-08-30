using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.Grocery_Shop
{
    public class Products
    {
        private string product;

        private double price;

        public Products(string product, double price)
        {
            this.product = product;

            this.price = price;
        }

        public string IProduct
        {
            get { return product; }

            set { this.product = value; }
        }

        public double Price
        {
            get { return price; }

            set { this.price = value; }
        }

        public override string ToString()
        {
            return $"{product} costs {price:F2}";
        }
    }

    public class GroceryShop
    {
        static string pattern = @"^(?<product>[A-Z]{1}[a-z]+)\:(?<price>[0-9]+\.[0-9]{2})$";

        static string product;

        static double price;

        static List<Products> productsList = new List<Products>();

        public static void Main()
        {
            ReadNextInputLinesUntilBillFrom(Console.ReadLine());

            productsList.OrderByDescending(p => p.Price).ToList()
                .ForEach(x => Console.WriteLine(x.ToString()));
        }

        static void ReadNextInputLinesUntilBillFrom(string inputProduct)
        {
            if (inputProduct != "bill")
            {
                if (Regex.IsMatch(inputProduct, pattern))
                {
                    var match = Regex.Match(inputProduct, pattern);

                    product = match.Groups["product"].Value;

                    price = Convert.ToDouble(match.Groups["price"].Value);

                    AddToProductsList();
                }

                ReadNextInputLinesUntilBillFrom(Console.ReadLine());
            }
        }

        static void AddToProductsList()
        {
            if (!productsList.Any(p => p.IProduct == product))
            {
                AddNewProduct();
            }

            else
            {
                UpdateProductPrice();
            }
        }

        static void AddNewProduct()
        {
            var newProduct = new Products(product, price);

            productsList.Add(newProduct);
        }

        private static void UpdateProductPrice()
        {
            var currentProduct = productsList.Where(p => p.IProduct == product).First();

            currentProduct.Price = price;
        }
    }
}
