using System;
using System.Linq;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    public class Max_Sequence_of_Increasing_Elements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            FindLongestSequence(numbers);
        }

        static void FindLongestSequence(int[] array)
        {
            int start = 0;

            int length = 1;

            int bestPosition = 0;

            int bestLength = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    length++;

                    if (length > bestLength)
                    {
                        bestLength = length;

                        bestPosition = start;
                    }
                }

                else
                {
                    if (length > bestLength)
                    {
                        bestPosition = start;

                        bestLength = length;
                    }

                    start = i;

                    length = 1;
                }
            }

            for (int i = bestPosition; i < bestPosition + bestLength; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
