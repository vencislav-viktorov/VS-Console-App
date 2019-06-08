using System;

namespace Array_Sum
{
    public class Program
    {
        public static void Main()
        {
            var result = FindSum(new[] { 1, 2, 3, }, 0);

            Console.WriteLine(result);
        }

        public static int FindSum(int[] numbers, int index)
        {
            if (index < numbers.Length)
            {
                var result = numbers[index] + FindSum(numbers, index + 1);

                return result;
            }

            return 0;
        }
    }
}
