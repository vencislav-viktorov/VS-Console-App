using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split('|').ToList();

            var finalList = new List<string>();

            numbers.Reverse();

            foreach (var item in numbers)
            {
                string[] currentNumbers = item.Split(' ');

                foreach (var number in currentNumbers)
                {
                    if (number != "")
                    {
                        finalList.Add(number);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
