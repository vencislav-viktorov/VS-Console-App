﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    public class Program
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int countElements = firstLine[0];
            int removeElements = firstLine[1];
            int existNum = firstLine[2];

            var secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Queue<int> numbers = new Queue<int>(secondLine);

            for (int i = 0; i < removeElements; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Any() == false)
            {
                Console.WriteLine("0");
            }
            else if (numbers.Contains(existNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestNum = int.MaxValue;

                foreach (var number in numbers)
                {
                    if (number < smallestNum)
                    {
                        smallestNum = number;
                    }
                }

                Console.WriteLine(smallestNum);
            }
        }
    }
}
