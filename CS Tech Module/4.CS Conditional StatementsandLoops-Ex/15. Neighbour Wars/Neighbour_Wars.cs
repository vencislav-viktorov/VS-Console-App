using System;

namespace _15.Neighbour_Wars
{
    public class Neighbour_Wars
    {
        public static void Main()
        {
            int peshoDemage = int.Parse(Console.ReadLine());

            int goshoDemage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;

            int goshoHealth = 100;

            int round = 1;

            while (true)
            {
                if (round % 2 == 0)
                {
                    peshoHealth -= goshoDemage;

                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                else
                {
                    goshoHealth -= peshoDemage;

                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }

                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }

                if (round % 3 == 0)
                {
                    peshoHealth += 10;

                    goshoHealth += 10;
                }

                round++;
            }
        }
    }
}