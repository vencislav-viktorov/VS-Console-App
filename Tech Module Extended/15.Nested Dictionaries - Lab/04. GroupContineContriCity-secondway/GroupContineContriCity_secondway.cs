using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GroupContineContriCity_secondway
{
    public class GroupContineContriCity_secondway
    {
        public static void Main()
        {
            var result = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split().ToList();

                var continent = entry[0];

                var country = entry[1];

                var city = entry[2];

                if (!result.ContainsKey(continent))
                {
                    result[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!result[continent].ContainsKey(country))
                {
                    result[continent].Add(country, new SortedSet<string>());
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
