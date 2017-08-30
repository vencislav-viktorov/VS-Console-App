using System;
using System.Linq;

namespace _13.IncreasingSequenceElement
{
    public class IncreasingSequenceElement
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
                if (massive[i] < massive[i - 1])
                {
                    lamp = true;
                    break;
                }
            }
            if (lamp == true)
            {
                Console.WriteLine("No");
            }

            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
