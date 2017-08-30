﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Distinct_List
{
    public class Distinct_List
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var result = RemoveRepeatingElements(numbers);
            
            Console.WriteLine(string.Join(" ", result));
        }

        static List<int> RemoveRepeatingElements(List<int> numbers)
        {
            var result = numbers;

            for (int i = 0; i < numbers.Count; i++)
            {
                var numberToCompare = numbers[i];

                var count = 0;

                for (int j = 0; j < result.Count; j++)
                {

                    if (result[j] == numbers[i])
                    {
                        count++;
                    }

                    if (count > 1)
                    {
                        result.RemoveAt(j);

                        j--;

                        count--;
                    }
                }
            }

            return result;
        }
    }
}
