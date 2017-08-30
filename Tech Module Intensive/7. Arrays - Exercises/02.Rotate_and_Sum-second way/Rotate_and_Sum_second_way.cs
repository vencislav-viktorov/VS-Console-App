using System;
using System.Linq;

namespace _02.Rotate_and_Sum_second_way
{
    public class Rotate_and_Sum_second_way
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rotationsCount = int.Parse(Console.ReadLine());

            int[] sumArray = new int[arr.Length];

            for (int i = 0; i < rotationsCount; i++)
            {
                RotateArray(arr);

                for (int j = 0; j < arr.Length; j++)
                {
                    sumArray[j] += arr[j];
                }
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }

        private static void RotateArray(int[] arr)
        {
            var lastElement = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = lastElement;
        }
    }
}
