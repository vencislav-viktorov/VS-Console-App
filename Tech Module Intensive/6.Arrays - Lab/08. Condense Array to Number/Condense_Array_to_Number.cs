using System;
using System.Linq;

namespace _08.Condense_Array_to_Number
{
    public class Condense_Array_to_Number
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length - 1];

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }

                nums = condensed;
            }

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
