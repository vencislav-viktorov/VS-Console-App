using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> partyList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine().Split();

                if (comand[2] == "going!")
                {
                    if (partyList.Contains(comand[0]))
                    {
                        Console.WriteLine($"{comand[0]} is already in the list!");
                    }

                    else
                    {
                        partyList.Add(comand[0]);
                    }
                }

                else
                {
                    if (partyList.Contains(comand[0]))
                    {
                        partyList.Remove(comand[0]);
                    }

                    else
                    {
                        Console.WriteLine($"{comand[0]} is not in the list!");
                    }
                }
            }

            foreach (var name in partyList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
