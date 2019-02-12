using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savingMoney = double.Parse(Console.ReadLine());

            var qualityOfEachDrum = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var currentQuality = new List<double>(qualityOfEachDrum);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Hit it again, Gabsy!")
                {
                    Console.WriteLine(string.Join(" ", currentQuality));

                    Console.WriteLine($"Gabsy has {savingMoney:F2}lv.");

                    break;
                }

                int hitPower = int.Parse(command);

                for (int i = 0; i < currentQuality.Count; i++)
                {
                    currentQuality[i] -= hitPower;

                    if (currentQuality[i] <= 0)
                    {
                        double currentPrice = qualityOfEachDrum[i] * 3;

                        if (currentPrice > savingMoney)
                        {
                            currentQuality.RemoveAt(i);

                            qualityOfEachDrum.RemoveAt(i);

                            i--;
                        }

                        else
                        {
                            currentQuality[i] = qualityOfEachDrum[i];

                            savingMoney -= currentPrice;
                        }
                    }
                }
            }
        }
    }
}
