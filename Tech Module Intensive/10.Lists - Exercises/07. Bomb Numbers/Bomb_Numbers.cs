using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Bomb_Numbers
{
    public class Bomb_Numbers
    {
        public static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] inputLine = Console.ReadLine().Split();

            int number = int.Parse(inputLine[0]);

            int power = int.Parse(inputLine[1]);

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == number)
                {
                    int left = Math.Max(i - power, 0);

                    int right = Math.Min(i + power, sequence.Count - 1);

                    int lenght = right - left + 1;

                    sequence.RemoveRange(left, lenght);

                    i = -1;
                }
            }

            Console.WriteLine(sequence.Sum());
        }
    }
}
