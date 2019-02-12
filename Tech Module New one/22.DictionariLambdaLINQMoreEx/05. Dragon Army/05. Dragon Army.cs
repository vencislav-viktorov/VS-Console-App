using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, double[]>> dragonStatistic = 
                new Dictionary<string, Dictionary<string, double[]>>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();

                string dragonType = tokens[0];

                string dragonName = tokens[1];

                string dragonDamage = tokens[2];

                if (dragonDamage == "null")
                {
                    dragonDamage = "45.00";
                }

                string dragonHealth = tokens[3];

                if (dragonHealth == "null")
                {
                    dragonHealth = "250.00";
                }

                string dragonArmor = tokens[4];

                if (dragonArmor == "null")
                {
                    dragonArmor = "10.00";
                }
                
                if (!dragonStatistic.ContainsKey(dragonType))
                {
                    dragonStatistic.Add(dragonType, new Dictionary<string, double[]>());
                }

                if (!dragonStatistic[dragonType].ContainsKey(dragonName))
                {
                    dragonStatistic[dragonType]
                        .Add(dragonName, new double[] { double.Parse(dragonDamage), double.Parse(dragonHealth), double.Parse(dragonArmor) });
                }

                else
                {
                    dragonStatistic[dragonType][dragonName] =
                        new double[] { double.Parse(dragonDamage), double.Parse(dragonHealth), double.Parse(dragonArmor) };
                }
            }

            foreach (var dragon in dragonStatistic)
            {
                var name = dragon.Value;

                double damageAverage = name.Values.Average(x => x[0]);

                double healthAverage = name.Values.Average(x => x[1]);

                double armorAverage = name.Values.Average(x => x[2]);

                Console.WriteLine($"{dragon.Key}::({damageAverage:f2}/{healthAverage:f2}/{armorAverage:f2})");

                foreach (var item in name.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{item.Key} -> damage: {item.Value[0]}, health: {item.Value[1]}, armor: {item.Value[2]}");
                }
            }
        }
    }
}
