using System;
using System.Linq;

namespace _02.Japanese_Roulette
{
    public class Japanese_Roulette
    {
        public static void Main()
        {
            var bulletPossition = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var rotation = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var startPosition = 0;

            var endPosition = 0;

            var dead = false;

            var deadPlayer = 0;

            for (int i = 0; i < bulletPossition.Count; i++)
            {
                if (bulletPossition[i] == 1)
                {
                    startPosition = i;
                }
            }

            for (int i = 0; i < rotation.Count; i++)
            {
                dead = false;

                var spin = rotation[i].Split(',').ToList();

                var strenght = int.Parse(spin[0]);

                var direction = spin[1];

                switch (direction)
                {
                    case "Right":
                        endPosition = (startPosition + strenght) % bulletPossition.Count;
                        startPosition = endPosition;
                        break;

                    case "Left":
                        endPosition = (startPosition - strenght) % bulletPossition.Count;

                        if (endPosition < 0)
                        {
                            endPosition += bulletPossition.Count;
                        }

                        startPosition = endPosition;

                        break;
                }

                if (endPosition == 2)
                {
                    deadPlayer = i;

                    dead = true;

                    break;
                }

                startPosition++;
            }

            if (dead)
            {
                Console.WriteLine($"Game over! Player {deadPlayer} is dead.");
            }

            else if (!dead)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
