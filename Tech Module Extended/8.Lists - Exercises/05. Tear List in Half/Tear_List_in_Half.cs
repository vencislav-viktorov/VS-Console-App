using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Tear_List_in_Half
{
    public class Tear_List_in_Half
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            TearListInHalfOutput(numbers);
        }

        static void TearListInHalfOutput(List<int> numbers)
        {
            var firstList = new List<int>();

            var secondList = new List<int>();

            var len = numbers.Count;

            for (int i = 0; i < len; i++)
            {
                if (i < (len / 2))
                {
                    firstList.Add(numbers[i]);
                }

                else
                {
                    secondList.Add(numbers[i]);
                }
            }

            ResultOutput(firstList, secondList);
        }

        static void ResultOutput(List<int> firstList, List<int> secondList)
        {
            var result = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                var firstDigit = secondList[i] / 10;

                var secondDigit = secondList[i] % 10;

                result.Add(firstDigit);

                result.Add(firstList[i]);

                result.Add(secondDigit);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
