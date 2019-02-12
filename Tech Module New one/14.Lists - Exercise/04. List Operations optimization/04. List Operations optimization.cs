using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations_optimization
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

                if (comand[0] == "End")
                {
                    break;
                }

                else if (comand[0] == "Add")
                {
                    numbers.Add(int.Parse(comand[1]));
                }

                else if (comand[0] == "Remove")
                {
                    int removeIndex = int.Parse(comand[1]);

                    if (removeIndex >= numbers.Count ||
                        removeIndex < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        numbers.RemoveAt(removeIndex);
                    }
                }

                else if (comand[0] == "Insert")
                {
                    int numberToAdd = int.Parse(comand[1]);
                    int indexToInsert = int.Parse(comand[2]);

                    if (indexToInsert >= numbers.Count ||
                        indexToInsert < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        numbers.Insert(indexToInsert, numberToAdd);
                    }
                }

                else
                {
                    string direction = comand[1];

                    int rotation = int.Parse(comand[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < rotation % numbers.Count; i++)
                        {
                            int firstNumber = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstNumber);
                        }
                    }

                    else
                    {
                        for (int i = 0; i < rotation % numbers.Count; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];
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
