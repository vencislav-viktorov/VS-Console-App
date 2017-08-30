using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Legendary_Farming_second_way
{
    public class Legendary_Farming_second_way
    {
        public static void Main()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();

            string legendarySword = "";

            materials.Add("fragments", 0);

            materials.Add("shards", 0);

            materials.Add("motes", 0);

            while (true)
            {
                string[] materialsObtained = Console.ReadLine().ToLower().Split().ToArray();

                for (int i = 1; i < materialsObtained.Length; i += 2)
                {
                    if (!materials.ContainsKey(materialsObtained[i]))
                    {
                        materials.Add(materialsObtained[i], 0);
                    }

                    materials[materialsObtained[i]] += int.Parse(materialsObtained[i - 1]);

                    legendarySword = GetLegendaryItem(materials, legendarySword);

                    if (!legendarySword.Equals(""))
                    {
                        break;
                    }
                }

                if (!legendarySword.Equals(""))
                {
                    break;
                }
            }

            PrintWeapon(materials, legendarySword);
        }

        private static string GetLegendaryItem(Dictionary<string, int> materials, string legendarySword)
        {
            if (materials["fragments"] >= 250)
            {
                legendarySword = "Valanyr";

                materials["fragments"] -= 250;
            }

            else if (materials["shards"] >= 250)
            {
                legendarySword = "Shadowmourne";

                materials["shards"] -= 250;
            }

            else if (materials["motes"] >= 250)
            {
                legendarySword = "Dragonwrath";

                materials["motes"] -= 250;
            }

            return legendarySword;
        }

        private static void PrintWeapon(Dictionary<string, int> materials, string legendarySword)
        {
            Console.WriteLine($"{legendarySword} obtained!");

            Dictionary<string, int> legendaryMaterials = new Dictionary<string, int>();

            SortedDictionary<string, int> otherMaterials = new SortedDictionary<string, int>();

            FillDictionaries(materials, legendaryMaterials, otherMaterials);

            PrintLegendaryMaterials(legendaryMaterials);

            PrintOtherMaterials(otherMaterials);
        }

        private static void PrintOtherMaterials(SortedDictionary<string, int> otherMaterials)
        {
            foreach (KeyValuePair<string, int> material in otherMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }

        private static void PrintLegendaryMaterials(Dictionary<string, int> legendaryMaterials)
        {
            foreach (KeyValuePair<string, int> material in
                legendaryMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }

        private static void FillDictionaries(Dictionary<string, int>
            materials, Dictionary<string, int> legendaryMaterials, SortedDictionary<string, int> otherMaterials)
        {
            foreach (KeyValuePair<string, int> material in materials)
            {
                if (material.Key.Equals("shards") || material.Key.Equals("fragments") || material.Key.Equals("motes"))
                {
                    legendaryMaterials.Add(material.Key, material.Value);
                }

                else
                {
                    otherMaterials.Add(material.Key, material.Value);
                }
            }
        }
    }
}
