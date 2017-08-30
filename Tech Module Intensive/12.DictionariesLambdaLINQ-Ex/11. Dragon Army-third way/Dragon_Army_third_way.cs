using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _11.Dragon_Army_third_way
{
    public class Dragon_Army_third_way
    {
        public static void Main()
        {
#if DEBUG
            Console.SetIn(new StreamReader("../../input.txt"));
#endif
            var dragonDictionary = new Dictionary<string, SortedSet<Dragon>>();

            int dragonCount = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < dragonCount; counter++)
            {
                Dragon dragon = ReadDragon();

                UpdateDragonDictionary(dragonDictionary, dragon);
            }

            foreach (var pair in dragonDictionary)
            {
                Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})",
                    pair.Key,
                    pair.Value
                        .Select(dragon => dragon.Damage)
                        .Average(),
                    pair.Value
                        .Select(dragon => dragon.Health)
                        .Average(),
                    pair.Value
                        .Select(dragon => dragon.Armor)
                        .Average());

                Console.WriteLine(string.Join("\n", pair.Value));
            }
        }

        private static void UpdateDragonDictionary(Dictionary<string, SortedSet<Dragon>> dragonDictionary, Dragon dragon)
        {
            if (!dragonDictionary.ContainsKey(dragon.Type))
            {
                dragonDictionary[dragon.Type] =
                    new SortedSet<Dragon>(DragonComparer.GetComparer());
            }

            if (dragonDictionary[dragon.Type].Contains(dragon))
                dragonDictionary[dragon.Type].Remove(dragon);

            dragonDictionary[dragon.Type].Add(dragon);
        }

        private static Dragon ReadDragon()
        {
            string[] dragonArgs = Console.ReadLine().Split();

            string type = dragonArgs[0];

            string name = dragonArgs[1];

            int? damage = (dragonArgs[2] != "null")
                ? (int?)int.Parse(dragonArgs[2])
                : null;

            int? health = (dragonArgs[3] != "null")
                ? (int?)int.Parse(dragonArgs[3])
                : null;

            int? armor = (dragonArgs[4] != "null")
                ? (int?)int.Parse(dragonArgs[4])
                : null;

            return new Dragon(type, name, damage, health, armor);
        }
    }

    class Dragon
    {
        private const int DefaultDamage = 45;

        private const int DefaultHealth = 250;

        private const int DefaultArmor = 10;

        public string Name { get; private set; }

        public string Type { get; private set; }

        public int Damage { get; private set; }

        public int Health { get; private set; }

        public int Armor { get; private set; }

        public Dragon(string type, string name, int? damage, int? health, int? armor)
        {
            Name = name;

            Type = type;

            Damage = damage ?? DefaultDamage;

            Health = health ?? DefaultHealth;

            Armor = armor ?? DefaultArmor;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj is Dragon && obj != null)
            {
                Dragon dragon = (Dragon)obj;

                return (dragon.Name == this.Name && dragon.Type == this.Type);
            }

            return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return (Name + Type).GetHashCode();
        }

        // override object.ToString
        public override string ToString()
        {
            return string.Format("-{0} -> damage: {1}, health: {2}, armor: {3}",
                Name,
                Damage,
                Health,
                Armor);
        }
    }

    class DragonComparer : IComparer<Dragon>
    {
        public int Compare(Dragon x, Dragon y)
        {
            return string.Compare(x.Name, y.Name);
        }

        public static IComparer<Dragon> GetComparer()
        {
            return new DragonComparer();
        }
    }
}
