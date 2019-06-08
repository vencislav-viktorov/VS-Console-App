namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var citizensAndRobots = new List<IIdentifiable>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input
                    .Split();

                if (tokens.Length == 3)
                {
                    var name = tokens[0];
                    var age = int.Parse(tokens[1]);
                    var id = tokens[2];
                    citizensAndRobots.Add(new Citizen(name, age, id));
                }

                else if (tokens.Length == 2)
                {
                    var model = tokens[0];
                    var id = tokens[1];
                    citizensAndRobots.Add(new Robot(model, id));
                }

                input = Console.ReadLine();
            }

            var lastDigitsOfFakeId = Console.ReadLine();

            citizensAndRobots
                .Where(c => c.Id.EndsWith(lastDigitsOfFakeId))
                .Select(c => c.Id)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}