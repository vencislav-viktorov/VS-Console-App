using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nameSide = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                string[] tokens = new string[0];

                if (input.Contains("|"))
                {
                    tokens = input.Split(" | ");

                    string side = tokens[0];

                    string name = tokens[1];

                    if (!nameSide.ContainsKey(name))
                    {
                        nameSide[name] = side;
                    }
                }

                else
                {
                    tokens = input.Split(" -> ");

                    string name = tokens[0];

                    string side = tokens[1];

                    if (nameSide.ContainsKey(name))
                    {
                        nameSide[name] = side;
                    }

                    else
                    {
                        nameSide[name] = side;
                    }

                    Console.WriteLine($"{name} joins the {side} side!");
                }
            }

            var filteredNameSide = nameSide
                .GroupBy(x => x.Value)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key);

            foreach (var kvp in filteredNameSide)
            {
                string side = kvp.Key;

                var nameSideValue = kvp;

                Console.WriteLine($"Side: {side}, Members: {nameSideValue.Count()}");

                foreach (var kvpValue in nameSideValue.OrderBy(x=>x.Key))
                {
                    string name = kvpValue.Key;

                    string side2 = kvpValue.Value;

                    Console.WriteLine($"! {name}");
                }

            }
        }
    }
}
