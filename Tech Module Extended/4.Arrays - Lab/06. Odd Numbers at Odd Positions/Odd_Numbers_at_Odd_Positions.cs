using System;
using System.Linq;

namespace _06.Odd_Numbers_at_Odd_Positions
{
    public class Odd_Numbers_at_Odd_Positions
    {
        public static void Main()
        {
            int[] massive = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {massive[i]}");
                }
            }
        }
    }
}
