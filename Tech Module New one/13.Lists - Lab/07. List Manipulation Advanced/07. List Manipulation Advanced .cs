using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool isModified = false;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                if (tokens[0] == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                    isModified = true;
                }

                if (tokens[0] == "Remove")
                {
                    numbers.Remove(int.Parse(tokens[1]));
                    isModified = true;
                }

                if (tokens[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(tokens[1]));
                    isModified = true;
                }

                if (tokens[0] == "Insert")
                {
                    numbers.Insert(int.Parse(tokens[2]) , int.Parse(tokens[1]));
                    isModified = true;
                }

                if (tokens[0] == "Contains")
                {
                    int numberToContains = int.Parse(tokens[1]);

                    if (numbers.Contains(numberToContains))
                    {
                        Console.WriteLine("Yes");
                    }

                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (tokens[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }

                else if (tokens[0] == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 1)));
                }

                else if (tokens[0] == "GetSum")
                {
                    Console.WriteLine(string.Join(" ", numbers.Sum()));
                }

                else if (tokens[0] == "Filter")
                {
                    string conditions = tokens[1];

                    int conditionsNumber = int.Parse(tokens[2]);

                    if (conditions == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > conditionsNumber)));
                    }

                    else if (conditions == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < conditionsNumber)));
                    }

                    else if (conditions == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= conditionsNumber)));
                    }

                    else if (conditions == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= conditionsNumber)));
                    }
                }
            }

            if (isModified)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
