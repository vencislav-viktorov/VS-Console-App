using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var colorClothCount = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                var colorClothes = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                var color = colorClothes[0];
                var clothes = colorClothes[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (colorClothCount.ContainsKey(color) == false)
                {
                    colorClothCount[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string cloth = clothes[j];

                    if (colorClothCount[color].ContainsKey(cloth) == false)
                    {
                        colorClothCount[color][cloth] = 0;
                    }

                    colorClothCount[color][cloth]++;
                }
            }

            var search = Console.ReadLine()
                .Split();
            var colorToSearch = search[0];
            var clothToSearch = search[1];

            foreach (var kvp in colorClothCount)
            {
                var color = kvp.Key;
                var clothCount = kvp.Value;
                Console.WriteLine($"{color} clothes:");

                foreach (var kvpClothCount in clothCount)
                {
                    var cloth = kvpClothCount.Key;
                    var count = kvpClothCount.Value;

                    if (color == colorToSearch && cloth == clothToSearch)
                    {
                        Console.WriteLine($"* {cloth} - {count} (found!)");
                    }

                    else
                    {
                        Console.WriteLine($"* {cloth} - {count}");
                    }
                }
            }
        }
    }
}