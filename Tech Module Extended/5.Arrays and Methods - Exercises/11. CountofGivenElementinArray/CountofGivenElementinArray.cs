using System;
using System.Linq;

namespace _11.CountofGivenElementinArray
{
    public class CountofGivenElementinArray
    {
        public static void Main()
        {
            int[] massive = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int num = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < massive.Length; i++)
            {
                if (num == massive[i])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
