using System;
using System.Linq;

namespace _05.Sort_Array_Using_Insertion_Sort
{
    public class Sort_Array_Using_Insertion_Sort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int sort = 0; sort < numbers.Length - 1; sort++)
                {
                    var first = numbers[sort];

                    var second = numbers[sort + 1];

                    if (second < first)
                    {
                        numbers[sort] = second;

                        numbers[sort + 1] = first;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
