using System;
using System.Collections.Generic;
using System.Linq;

namespace Iron_Girder_2nd_way
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> townAndTimes = new Dictionary<string, int>();

            Dictionary<string, int> townAndPassengers = new Dictionary<string, int>();

            while (input[0] != "Slide rule")
            {
                string town = input[0];
                int passengers = int.Parse(input[2]);

                if (input[1] == "ambush")
                {
                    if (townAndTimes.ContainsKey(town))
                    {
                        townAndTimes[town] = 0;
                        townAndPassengers[town] -= passengers;
                    }
                }

                else
                {
                    int time = int.Parse(input[1]);

                    if (townAndTimes.ContainsKey(town) == false)
                    {
                        townAndTimes.Add(town, time);
                        townAndPassengers.Add(town, 0);
                    }

                    townAndPassengers[town] += passengers;

                    if (townAndTimes[town] > time || townAndTimes[town] == 0)
                    {
                        townAndTimes[town] = time;
                    }
                }

                input = Console.ReadLine().Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var town in townAndTimes
                .OrderBy(t => t.Value)
                .ThenBy(t => t.Key)
                .Where(t => t.Value != 0))
            {
                if (townAndPassengers[town.Key] > 0)
                {
                    Console.WriteLine($"{town.Key} -> Time: {town.Value} -> Passengers: {townAndPassengers[town.Key]}");
                }
            }
        }
    }
}
