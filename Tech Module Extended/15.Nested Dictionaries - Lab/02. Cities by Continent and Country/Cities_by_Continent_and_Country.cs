using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Cities_by_Continent_and_Country
{
    public class Cities_by_Continent_and_Country
    {
        public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, List<string>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var entryParts = Console.ReadLine()
                    .Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var continent = entryParts[0];

                var country = entryParts[1];

                var city = entryParts[2];

                if (!result.ContainsKey(continent))
                {
                    result[continent] = new Dictionary<string, List<string>>();
                }

                if (!result[continent].ContainsKey(country))
                {
                    result[continent].Add(country, new List<string>());
                }

                result[continent][country].Add(city);
            }

            foreach (var KvP in result)
            {
                Console.WriteLine($"{KvP.Key}: ");

                foreach (var item in KvP.Value)
                {
                    Console.WriteLine($"{string.Join(", ", item.Key)} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
