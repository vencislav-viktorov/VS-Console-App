using System;

namespace _09.Largest_Element_in_Array
{
    public class Largest_Element_in_Array
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int largestElement = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] > largestElement)
                {
                    largestElement = numbers[i];
                }
            }

            Console.WriteLine(largestElement);
        }
    }
}
