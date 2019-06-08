using System;
using System.Collections.Generic;
using System.Linq;

namespace Iron_Girder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> trains = new Dictionary<string, int[]>();

            string line = Console.ReadLine();

            while (line != "Slide rule")
            {
                string[] tokens = line.Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];

                string time = tokens[1];

                string passenger = tokens[2];

                if (time == "ambush")
                {
                    if (trains.ContainsKey(name))
                    {
                        trains[name][0] = 0;

                        trains[name][1] -= int.Parse(passenger);
                    }
                }

                else
                {
                    if (trains.ContainsKey(name) == false)
                    {
                        trains.Add(name, new int[2]);
                        trains[name][0] = int.Parse(time);
                        trains[name][1] = 0;
                    }

                    if (trains[name][0] > int.Parse(time) || trains[name][0] == 0)
                    {
                        trains[name][0] = int.Parse(time);
                    }

                    trains[name][1] += int.Parse(passenger);
                }

                line = Console.ReadLine();
            }

            foreach (var train in trains.OrderBy(t => t.Value[0]).ThenBy(t => t.Key).Where(t => t.Value[0] != 0).Where(x => x.Value[1] != 0))
            {
                if (train.Value[0] > 0 || train.Value[1] > 0)
                {
                    Console.WriteLine($"{train.Key} -> Time: {train.Value[0]} -> Passengers: {train.Value[1]}");
                }
            }
        }
    }
}
