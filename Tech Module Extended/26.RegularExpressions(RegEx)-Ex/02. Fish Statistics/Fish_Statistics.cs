using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Fish_Statistics
{
    public class Fish
    {
        public string Fisch { get; set; }

        public string Tile { get; set; }

        public string Body { get; set; }

        public string Status { get; set; }

        public static Fish Parce(string a, string b, string c, string d)
        {
            return new Fish()
            {
                Fisch = a,

                Tile = b,

                Body = c,

                Status = d
            };
        }
    }

    public class Fish_Statistics
    {
        public static void Main()
        {
            var fishSequence = Console.ReadLine();

            var regex = new Regex(@"(>*)<(\(+)('|x|-)>|<('|x|-)(\)+)>(<*)");

            var matches = regex.Matches(fishSequence);

            var fishes = new List<Fish>();

            var hasFish = false;

            foreach (Match fish in matches)
            {
                var fishDirection = fish.Groups[2].ToString();

                if (fishDirection.Contains("("))
                {
                    var currentFish = Fish.Parce(fish.Value, fish.Groups[1].ToString(),

                   fish.Groups[2].ToString(), fish.Groups[3].ToString());

                    fishes.Add(currentFish);
                }

                else
                {
                    var currentFish = Fish.Parce(fish.Value, fish.Groups[6].ToString(),

                    fish.Groups[5].ToString(), fish.Groups[4].ToString());

                    fishes.Add(currentFish);
                }

                hasFish = true;
            }

            var n = 1;

            foreach (var item in fishes)
            {
                Console.WriteLine($"Fish {n}: {item.Fisch}");

                var tileLenght = item.Tile.Length > 5 ? "Long" : item.Tile.Length > 1 ? "Medium" :

                    item.Tile.Length == 1 ? "Short" : "None";

                Console.WriteLine($"  Tail type: {tileLenght} ({item.Tile.Length * 2} cm)");

                var bodyLenght = item.Body.Length > 10 ? "Long" : item.Body.Length > 5 ? "Medium" : "Short";

                Console.WriteLine($"  Body type: {bodyLenght} ({item.Body.Length * 2} cm)");

                var status = item.Status == "'" ? "Awake" : item.Status == "-" ? "Asleep" : "Dead";

                Console.WriteLine($"  Status: {status}");

                n++;
            }

            if (!hasFish)
            {
                Console.WriteLine("No fish found.");
            }
        }
    }
}
