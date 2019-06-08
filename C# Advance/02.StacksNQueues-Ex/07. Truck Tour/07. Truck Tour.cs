using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    public class Program
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            var pumps = new Queue<int[]>();

            bool fullCircle = true;

            for (int i = 0; i < linesCount; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(input);
            }

            for (int i = 0; i < linesCount; i++)
            {
                int fuel = 0;

                for (int j = 0; j < linesCount; j++)
                {
                    int[] currentPump = pumps.Dequeue();

                    fuel += (currentPump[0] - currentPump[1]);

                    if (fuel < 0)
                    {
                        fullCircle = false;
                    }

                    pumps.Enqueue(currentPump);
                }

                if (fullCircle)
                {
                    Console.WriteLine(i);

                    break;
                }

                int[] startingPump = pumps.Dequeue();

                pumps.Enqueue(startingPump);

                fullCircle = true;
            }
        }
    }
}
