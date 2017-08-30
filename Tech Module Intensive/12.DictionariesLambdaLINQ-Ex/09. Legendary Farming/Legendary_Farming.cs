using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Legendary_Farming
{
    public class Legendary_Farming
    {
        public static void Main()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();

            string legendarySword = String.Empty;

            while (true)
            {
                string[] materialsObtained = Console.ReadLine().ToLower().Split().ToArray();

                bool isEnough = false;

                for (int i = 1; i < materialsObtained.Length; i += 2)
                {
                    if (!materials.ContainsKey(materialsObtained[i]))
                    {
                        materials.Add(materialsObtained[i], 0);
                    }

                    materials[materialsObtained[i]] += int.Parse(materialsObtained[i - 1]);

                    if (materials[materialsObtained[i]] >= 250)
                    {

                        if (materialsObtained[i].Equals("shards"))
                        {
                            legendarySword = "Shadowmourne";

                            isEnough = true;

                            break;
                        }

                        else if (materialsObtained[i].Equals("fragments"))
                        {
                            legendarySword = "Valanyr";

                            isEnough = true;

                            break;
                        }

                        else if (materialsObtained[i].Equals("motes"))
                        {
                            legendarySword = "Dragonwrath";

                            isEnough = true;

                            break;
                        }
                    }

                    if (isEnough)
                    {
                        break;
                    }
                }

                if (isEnough)
                {
                    break;
                }
            }

            PrintWeapon(materials, legendarySword);
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

                    if (material.Value >= 250)
                    {
                        legendaryMaterials[material.Key] -= 250;
                    }
                }

                else
                {
                    otherMaterials.Add(material.Key, material.Value);
                }
            }

            if (!legendaryMaterials.ContainsKey("fragments"))
            {
                legendaryMaterials.Add("fragments", 0);
            }

            if (!legendaryMaterials.ContainsKey("shards"))
            {
                legendaryMaterials.Add("shards", 0);
            }

            if (!legendaryMaterials.ContainsKey("motes"))
            {
                legendaryMaterials.Add("motes", 0);
            }
        }
    }
}
