using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLine = int.Parse(Console.ReadLine());

            Dictionary<string, string> register = new Dictionary<string, string>();

            for (int i = 0; i < countLine; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                string name = tokens[1];
            
                if (tokens[0] == "register")
                {
                    string plateNumber = tokens[2];

                    if (!register.ContainsKey(name))
                    {
                        register[name] = plateNumber;

                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {register[name]}");
                    }
                }

                else
                {
                    if (register.ContainsKey(name))
                    {
                        register.Remove(name);

                        Console.WriteLine($"{name} unregistered successfully");
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }

            foreach (var kvp in register)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
