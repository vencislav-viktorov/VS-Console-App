using System;
using System.Linq;

namespace _10.Pairs_by_Difference
{
    public class Pairs_by_Difference
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split()
               .Select(int.Parse)
               .ToArray();

            FindPair(numbers);
        }

        static void FindPair(int[] numbers)
        {
            int difference = int.Parse(Console.ReadLine());

            int pairs = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    else
                    {
                        if (Math.Abs(numbers[i] - numbers[j]) == difference)
                        {
                            pairs++;
                        }
                    }
                }
            }

            Console.WriteLine(pairs);
        }
    }
}
