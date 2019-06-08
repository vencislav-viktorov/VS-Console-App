using System;
using System.Collections.Generic;

namespace GenericCountMethodString
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

            var element = Console.ReadLine();

            var count = GetCountOfGreaterElements(box.Data, element);
            Console.WriteLine(count);
        }

        public static int GetCountOfGreaterElements<T>(List<T> listWithData, T element)
            where T : IComparable
        {
            var count = 0;

            foreach (var item in listWithData)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
