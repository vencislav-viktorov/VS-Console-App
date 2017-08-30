using System;
using System.Linq;

namespace _14.EqualSequenceofElement
{
    public class EqualSequenceofElement
    {
        public static void Main()
        {
            int[] massive = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool lamp = false;

            for (int i = 1; i < massive.Length; i++)
            {
                if (massive[i - 1] == massive[i])
                {
                    lamp = true;
                }

                else
                {
                    lamp = false;
                    break;
                }
            }

            if (lamp)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
