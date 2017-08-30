using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Ununion_Lists
{
    public class Ununion_Lists
    {
        public static void Main()
        {
            var primalList = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var numberOfNextLists = int.Parse(Console.ReadLine());

            var sortedPrimalList = SortPrimalList(primalList, numberOfNextLists);

            Console.WriteLine(sortedPrimalList);
        }

        static string SortPrimalList(List<int> primalList, int numberOfNextLists)
        {
            var result = new List<int>();

            var n = numberOfNextLists;

            primalList.Sort();

            result = primalList;

            while (n != 0)
            {
                var newList = Console.ReadLine()
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                newList.Sort();

                var count = 0;

                for (int j = 0; j < newList.Count; j++)
                {
                    var compareNumber = newList[j];

                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i] == compareNumber)
                        {
                            result.RemoveAt(i);

                            i--;

                            count++;
                        }
                    }

                    if (count > 0)
                    {
                        newList.Remove(compareNumber);

                        j--;

                        count = 0;
                    }
                }

                for (int i = 0; i < newList.Count; i++)
                {
                    result.Add(newList[i]);
                }

                n--;
            }

            result.Sort();

            var output = string.Join(" ", result);

            return output;
        }
    }
}
