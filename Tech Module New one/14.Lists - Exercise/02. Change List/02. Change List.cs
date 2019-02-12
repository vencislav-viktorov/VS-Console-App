using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] comand = Console.ReadLine().Split();

                if (comand[0] == "end")
                {
                    break;
                }

                else if (comand[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(comand[1]));
                }

                else
                {
                    numbers.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
