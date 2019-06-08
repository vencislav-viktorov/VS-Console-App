using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());

            int barrelSize = int.Parse(Console.ReadLine());

            var bullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            var locks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            int money = int.Parse(Console.ReadLine());

            var bulletsValue = new Stack<int>(bullets);

            var locksValue = new Stack<int>(locks);

            int count = 0;

            int bulletCount = bulletsValue.Count;

            while (bulletsValue.Any() && locksValue.Any())
            {
                int bullet = bulletsValue.Pop();

                int @lock= locksValue.Pop();

                if (bullet > @lock)
                {
                    Console.WriteLine("Ping!");

                    locksValue.Push(@lock);
                }

                else
                {
                    Console.WriteLine("Bang!");
                }

                count++;

                if (count == barrelSize && bulletsValue.Any())
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }
            }

            if (locksValue.Any() == false)
            {
                int leftMoney = money - (bulletCount - bulletsValue.Count) * bulletPrice;

                Console.WriteLine($"{bulletsValue.Count} bullets left. Earned ${leftMoney}");
            }

            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksValue.Count}");
            }
        }
    }
}
