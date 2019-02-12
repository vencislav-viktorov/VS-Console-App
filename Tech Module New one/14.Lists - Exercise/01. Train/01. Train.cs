using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] comand = Console.ReadLine().Split();

                if (comand[0] == "end")
                {
                    break;
                }

                else if (comand[0] == "Add")
                {
                    wagons.Add(int.Parse(comand[1]));
                }

                else
                {
                    int increasePasenger = int.Parse(comand[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + increasePasenger <= 
                            wagonCapacity)
                        {
                            wagons[i] += increasePasenger;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
