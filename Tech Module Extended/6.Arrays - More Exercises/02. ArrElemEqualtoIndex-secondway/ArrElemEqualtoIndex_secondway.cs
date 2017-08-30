using System;
using System.Linq;

namespace _02.ArrElemEqualtoIndex_secondway
{
    public class ArrElemEqualtoIndex_secondway
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == i)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
