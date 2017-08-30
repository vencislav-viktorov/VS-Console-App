using System;
using System.Linq;

namespace _03.Smallest_Element_in_Array
{
    public class Smallest_Element_in_Array
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int minNum = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (minNum > numbers[i])
                {
                    minNum = numbers[i];
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
