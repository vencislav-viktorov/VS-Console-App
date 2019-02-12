using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersAsStrings = Console.ReadLine()
                                            .Split('|')
                                            .Reverse()
                                            .ToList();

            List<int> finalList = new List<int>();

            foreach (var item in numbersAsStrings)
            {
                finalList.AddRange(item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList()
                                    );
            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
