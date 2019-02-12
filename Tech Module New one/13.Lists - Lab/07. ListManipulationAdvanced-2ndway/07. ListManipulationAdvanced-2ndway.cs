using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._ListManipulationAdvanced_2ndway
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool listIsChange = false;

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Contains":
                        int element = int.Parse(tokens[1]);

                        if (numbers.Contains(element))
                        {
                            Console.WriteLine("Yes");
                        }

                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                        break;

                    case "GetSum":
                        Console.WriteLine(string.Join(" ", numbers.Sum()));
                        break;

                    case "Filter":
                        string condition = tokens[1];
                        int conditionNumber = int.Parse(tokens[2]);

                        if (condition == "<")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x < conditionNumber)));
                        }

                        else if (condition == ">")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x > conditionNumber)));
                        }

                        else if (condition == "<=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x <= conditionNumber)));
                        }

                        else if (condition == ">=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= conditionNumber)));
                        }
                        break;
                        
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        listIsChange = true;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        listIsChange = true;
                        break;

                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemoveAt);
                        listIsChange = true;
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        listIsChange = true;
                        break;

                    default:
                        break;
                }

                line = Console.ReadLine();
            }

            if (listIsChange)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}