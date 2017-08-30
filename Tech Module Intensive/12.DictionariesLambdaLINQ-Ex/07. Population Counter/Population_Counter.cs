using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Population_Counter
{
    public class Population_Counter
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> citiesInformation = new Dictionary<string,
                Dictionary<string, long>>();

            string[] cityInformation = Console.ReadLine().Split('|').ToArray();

            while (!cityInformation[0].Equals("report"))
            {
                string country = cityInformation[1];

                string city = cityInformation[0];

                long populationCount = long.Parse(cityInformation[2]);

                InsertCountry(citiesInformation, country);

                InsertCityPopulation(citiesInformation, country, city, populationCount);

                cityInformation = Console.ReadLine().Split('|').ToArray();
            }

            PrintCityInformation(citiesInformation);
        }

        private static void PrintCityInformation(Dictionary<string, Dictionary<string, long>> citiesInformation)
        {
            foreach (KeyValuePair<string, Dictionary<string, long>>
                cityEntry in citiesInformation.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{cityEntry.Key} (total population: {cityEntry.Value.Values.Sum()})");

                foreach (KeyValuePair<string, long> populationEntry in cityEntry.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{populationEntry.Key}: {populationEntry.Value}");
                }
            }
        }

        private static void InsertCityPopulation(Dictionary<string, Dictionary<string, long>>
            citiesInformation, string country, string city, long populationCount)
        {
            if (!citiesInformation[country].ContainsKey(city))
            {
                citiesInformation[country].Add(city, 0);
            }

            citiesInformation[country][city] += populationCount;
        }

        private static void InsertCountry(Dictionary<string, Dictionary<string, long>>
            citiesInformation, string country)
        {
            if (!citiesInformation.ContainsKey(country))
            {
                citiesInformation.Add(country, new Dictionary<string, long>());
            }
        }
    }
}
