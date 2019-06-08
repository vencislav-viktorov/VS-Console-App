using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());
            var box = new Box<string>();

            for (int i = 0; i < linesCount; i++)
            {
                var line = Console.ReadLine();
                box.Add(line);
            }

            var indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var firstIndex = indexes[0];
            var secondIndex = indexes[1];
            //box.Swap(firstIndex, secondIndex);
            Swap(box.Data,firstIndex,secondIndex);
            Console.WriteLine(box);
        }

        static void Swap<T>(List<T> listWithData, int firstIndex, int secondIndex)
        {
            var temp = listWithData[firstIndex];
            listWithData[firstIndex] = listWithData[secondIndex];
            listWithData[secondIndex] = temp;
        }
    }
}
