using System;
using System.Linq;

namespace _04.Sort_Array_Using_Bubble_Sort
{
    public class Sort_Array_Using_Bubble_Sort
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

                    if (first > second)
                    {
                        var temp = numbers[sort + 1];

                        numbers[sort + 1] = numbers[sort];

                        numbers[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
