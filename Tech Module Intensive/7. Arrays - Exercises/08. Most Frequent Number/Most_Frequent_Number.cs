using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    public class Most_Frequent_Number
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            NumberFinder(numbers);

        }

        static void NumberFinder(int[] numbers)
        {
            Dictionary<int, int> nums = new Dictionary<int, int>();

            foreach (int n in numbers)
            {
                if (!nums.ContainsKey(n))
                {
                    nums.Add(n, 0);
                }

                nums[n] += 1;
            }

            int mostCommonValue = 0;

            int highestCount = 0;

            foreach (KeyValuePair<int, int> pair in nums)
            {
                if (pair.Value > highestCount)
                {
                    mostCommonValue = pair.Key;

                    highestCount = pair.Value;
                }
            }

            Console.WriteLine(mostCommonValue);
        }
    }
}
