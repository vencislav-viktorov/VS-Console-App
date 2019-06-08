namespace FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var buyers = new List<IBuyer>();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine()
                    .Split();

                if (tokens.Length == 4)
                {
                    var name = tokens[0];
                    var age = int.Parse(tokens[1]);
                    var id = tokens[2];
                    var birthdate = tokens[3];
                    
                    buyers.Add(new Citizen(name, age, id, birthdate));
                }

                else if (tokens.Length == 3)
                {
                    var name = tokens[0];
                    var age = int.Parse(tokens[1]);
                    var group = tokens[2];

                    buyers.Add(new Rebel(name, age, group));
                }
            }

            var command  = Console.ReadLine();

            while (command  != "End")
            {
                var buyer = buyers
                    .SingleOrDefault(b => b.Name == command);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}