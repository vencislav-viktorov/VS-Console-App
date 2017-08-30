using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Equal_Sum_After_Extraction
{
    public class Equal_Sum_After_Extraction
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            EqualSumA(firstList, secondList);
        }

        static void EqualSumA(List<int> firstList, List<int> secondList)
        {
            var firstSum = 0;

            var secondSum = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                firstSum += firstList[i];

                for (var s = 0; s < secondList.Count; s++)
                {
                    if (firstList[i] == secondList[s])
                    {
                        secondList.RemoveAt(s);
                    }
                }
            }

            foreach (var number in secondList)
            {
                secondSum += number;
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes. Sum: {firstSum}");
            }

            else
            {
                var diff = Math.Abs(firstSum - secondSum);

                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}
