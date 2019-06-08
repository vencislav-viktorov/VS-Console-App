using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    public class Program
    {
        public static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());

            int barrelSize = int.Parse(Console.ReadLine());

            var bulletsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var bullets = new Stack<int>(bulletsInput);

            var locksInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var locks = new Queue<int>(locksInput);

            int intelligenceValue = int.Parse(Console.ReadLine());

            int counter = 0;

            while (true)
            {
                if (locks.Count == 0)
                {
                    int earnings = intelligenceValue - (counter * bulletPrice);

                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnings}");
                    break;
                }

                else if (bullets.Count == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    break;
                }

                int currentBullet = bullets.Pop();

                counter++;

                if (currentBullet <= locks.Peek())
                {
                    locks.Dequeue();

                    Console.WriteLine("Bang!");
                }

                else
                {
                    Console.WriteLine("Ping!");
                }

                if (counter % barrelSize == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
        }
    }
}
