using System;
using System.Collections.Generic;

namespace _01.Shellbound_second_way
{
    public class Shellbound_second_way
    {
        public static void Main()
        {
            var result = new Dictionary<string, HashSet<int>>();

            var input = Console.ReadLine();

            while (input != "Aggregate")
            {
                var inputParts = input.Split();

                var city = inputParts[0];

                var size = int.Parse(inputParts[1]);

                if (!result.ContainsKey(city))
                {
                    result[city] = new HashSet<int>();
                }

                result[city].Add(size);

                input = Console.ReadLine();
            }

            foreach (var kvp in result)
            {
                var giantShell = 0;

                foreach (var sizes in kvp.Value)
                {
                    giantShell += sizes;
                }

                Console.WriteLine($"{kvp.Key} -> {string.Join(", ", kvp.Value)} " +
                    $"({giantShell - giantShell / kvp.Value.Count})");
            }
        }
    }
}
