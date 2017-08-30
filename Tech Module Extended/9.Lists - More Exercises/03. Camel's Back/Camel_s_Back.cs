using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Camel_s_Back
{
    public class Camel_s_Back
    {
        public static void Main()
        {
            //var text = "8 7 8 1 2 3 8 7 2 44 3 212 11";
            var buildingsInTheCity = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var camelBackSize = int.Parse(Console.ReadLine());

            var result = StableBuildingsOnTheBackOfCamel(buildingsInTheCity, camelBackSize);

            Console.WriteLine(result);
        }

        static string StableBuildingsOnTheBackOfCamel(List<int> buildingsInTheCity, int camelBackSize)
        {
            var buildingsToRemove = 0;

            var lenghtOfTheBuildings = buildingsInTheCity.Count;

            var result = string.Empty;

            var rounds = 0;

            var removeBuildings = string.Empty;

            if (lenghtOfTheBuildings <= camelBackSize)
            {
                result = $"already stable: {string.Join(" ", buildingsInTheCity)}";
            }

            else if (lenghtOfTheBuildings > camelBackSize)
            {
                buildingsToRemove = lenghtOfTheBuildings - camelBackSize;

                rounds = buildingsToRemove / 2;

                removeBuildings = RemoveByildings(buildingsInTheCity, buildingsToRemove);

                result = $"{rounds} rounds \nremaining: {removeBuildings}";
            }

            return result;
        }

        static string RemoveByildings(List<int> buildingsInTheCity, int buildingsToRemove)
        {
            var resultList = new List<int>();

            var removeAtStart = buildingsToRemove / 2;

            var removeAtEnd = buildingsInTheCity.Count - removeAtStart;

            for (int i = removeAtStart; i < removeAtEnd; i++)
            {
                resultList.Add(buildingsInTheCity[i]);
            }

            return string.Join(" ", resultList);
        }
    }
}
