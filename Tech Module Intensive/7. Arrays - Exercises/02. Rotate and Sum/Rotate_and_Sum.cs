using System;
using System.Linq;

namespace _02.Rotate_and_Sum
{
    public class Rotate_and_Sum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rotationsCount = int.Parse(Console.ReadLine());

            int[] rotated = new int[numbers.Length];

            for (int i = 0; i < rotationsCount; i++)
            {
                int temp = numbers[numbers.Length - 1];

                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = temp;

                for (int l = 0; l < numbers.Length; l++)
                {
                    rotated[l] += numbers[l];
                }
            }

            Console.WriteLine(string.Join(" ", rotated));
        }
    }
}
