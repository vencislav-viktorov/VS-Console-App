using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Flip_List_Sides
{
    public class Flip_List_Sides
    {
        public static void Main()
        {
            var inputList = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            FlipList(inputList);
        }

        static void FlipList(List<int> inputList)
        {
            var outputList = new List<int>();

            var last = inputList.Count - 1;

            outputList.Add(inputList[0]);

            for (int i = inputList.Count - 2; i >= 1; i--)
            {
                outputList.Add(inputList[i]);
            }

            outputList.Add(inputList[last]);

            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}
