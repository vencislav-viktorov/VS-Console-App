using System;

namespace _10.NegativeElements_second_way
{
    public class NegativeElements_second_way
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] massive = new int[n];

            int count = 0;

            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = int.Parse(Console.ReadLine());

                if (massive[i] < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
