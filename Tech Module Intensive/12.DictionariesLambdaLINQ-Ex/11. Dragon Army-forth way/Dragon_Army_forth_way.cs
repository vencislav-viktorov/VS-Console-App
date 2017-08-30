using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _11.Dragon_Army_forth_way
{
    public class Dragon_Army_forth_way
    {
        public static void Main()
        {
            var data = new Dictionary<string, SortedDictionary<string, int[]>>();

            var regex = new Regex(@"([a-zA-Z]*)\s*([a-zA-Z]*)\s*(null|\d+)\s*(null|\d+)\s*(null|\d+)");

            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var match = regex.Match(input);

                if (match.Success)
                {
                    var type = match.Groups[1].Value;

                    var name = match.Groups[2].Value;

                    var damage = 0;

                    var health = 0;

                    var armor = 0;

                    damage = match.Groups[3].Value == "null" ? 45 : int.Parse(match.Groups[3].Value);

                    health = match.Groups[4].Value == "null" ? 250 : int.Parse(match.Groups[4].Value);

                    armor = match.Groups[5].Value == "null" ? 10 : int.Parse(match.Groups[5].Value);

                    if (!data.ContainsKey(type))
                    {
                        data.Add(type, new SortedDictionary<string, int[]>());
                    }

                    if (!data[type].ContainsKey(name))
                    {
                        data[type][name] = new int[3];
                    }

                    data[type][name][0] = damage;

                    data[type][name][1] = health;

                    data[type][name][2] = armor;
                }
            }

            foreach (var outerPair in data)
            {
                var average = CalculateAverage(outerPair.Value);

                Console.WriteLine("{0}::({1:F}/{2:f}/{3:f})", outerPair.Key, average[0],
                    average[1], average[2]);

                foreach (var inner in outerPair.Value)
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", inner.Key, inner.Value[0],
                        inner.Value[1], inner.Value[2]);
                }
            }
        }

        private static double[] CalculateAverage(SortedDictionary<string, int[]> list)
        {
            double totalEntries = list.Count;

            var totalDamage = 0;

            var totalHealth = 0;

            var totalArmor = 0;

            foreach (var element in list)
            {
                totalDamage += element.Value[0];

                totalHealth += element.Value[1];

                totalArmor += element.Value[2];
            }

            return new[]
            {
                totalDamage/totalEntries, totalHealth/totalEntries, totalArmor/totalEntries
            };
        }
    }
}
