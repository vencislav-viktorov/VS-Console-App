using System;
using System.Linq;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    public class Count_of_Odd_Numbers_in_Array
    {
        public static void Main()
        {
            int[] massive = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int count = 0;

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
