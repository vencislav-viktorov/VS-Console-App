using System;
using System.Collections.Generic;

namespace _04._CitiesbyContinentNCountry
{
    class Program
    {
        static void Main()
        {
            var continentCountryCity = new Dictionary<string, Dictionary<string, List<string>>>();

            var totalCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalCommands; i++)
            {
                var commmandParts = Console.ReadLine()
                    .Split();

                var continent = commmandParts[0];

                var country = commmandParts[1];

                var city = commmandParts[2];

                if (continentCountryCity.ContainsKey(continent) == false)
                {
                    continentCountryCity[continent] = new Dictionary<string, List<string>>();
                }

                if (continentCountryCity[continent].ContainsKey(country) == false)
                {
                    continentCountryCity[continent].Add(country, new List<string>());
                }

                continentCountryCity[continent][country].Add(city);

            }

            foreach (var continent in continentCountryCity)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}