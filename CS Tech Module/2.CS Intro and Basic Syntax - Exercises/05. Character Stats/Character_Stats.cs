using System;

namespace _05.Character_Stats
{
    public class Character_Stats
    {
        public static void Main()
        {
            string Name = Console.ReadLine();

            int currentHeaalth = int.Parse(Console.ReadLine());

            int maxHealth = int.Parse(Console.ReadLine());

            int currentEnergy = int.Parse(Console.ReadLine());

            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {Name}");

            Console.WriteLine("Health: |{0}{1}|", 
                new string('|', currentHeaalth), new string('.', maxHealth - currentHeaalth));

            Console.WriteLine("Energy: |{0}{1}|", 
                new string('|', currentEnergy), new string('.', maxEnergy - currentEnergy));
        }
    }
}
