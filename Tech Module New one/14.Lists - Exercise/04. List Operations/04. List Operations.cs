using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

                string cmd = comand[0];

                if (cmd == "End")
                {
                    break;
                }

                else if (cmd == "Add")
                {
                    numbers.Add(int.Parse(comand[1]));
                }

                else if (cmd == "Remove")
                {
                    int index = int.Parse(comand[1]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        numbers.RemoveAt(int.Parse(comand[1]));
                    }
                }

                else if (cmd == "Insert")
                {
                    int index = int.Parse(comand[2]);

                    int numToIndex = int.Parse(comand[1]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        numbers.Insert(index, numToIndex);
                    }
                }

                else
                {
                    int rotation = int.Parse(comand[2]);

                    if (comand[1] == "left")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int firstNumber = numbers.First();
                            numbers.RemoveAt(0);
                            numbers.Add(firstNumber);
                        }
                    }

                    else
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int lastNumber = numbers.Last();
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastNumber);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
