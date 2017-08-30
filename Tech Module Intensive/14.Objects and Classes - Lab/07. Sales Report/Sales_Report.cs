using System;
using System.Linq;

namespace _07.Sales_Report
{
    class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }
    }

    public class Sales_Report
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Sale[] sales = new Sale[n];

            for (int i = 0; i < n; i++)
                sales[i] = GetSales();

            string[] towns = sales.Select(x => x.Town).Distinct().OrderBy(x => x).ToArray();

            foreach (string town in towns)
            {
                decimal salesByTown = sales.Where(x => x.Town == town).Select(x => x.Price * x.Quantity).Sum();

                Console.WriteLine("{0} -> {1:f2}", town, salesByTown);
            }
        }

        private static Sale GetSales()
        {
            string[] data = Console.ReadLine()
                .Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);

            Sale sale = new Sale()
            {
                Town = data[0],

                Product = data[1],

                Price = decimal.Parse(data[2]),

                Quantity = decimal.Parse(data[3])
            };

            return sale;
        }
    }
}