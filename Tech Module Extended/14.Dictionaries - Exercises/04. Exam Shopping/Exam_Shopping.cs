using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Exam_Shopping
{
    public class Exam_Shopping
    {
        public static void Main()
        {
            string enterTheConsole = Console.ReadLine();

            Dictionary<string, int> answer = new Dictionary<string, int>();

            while (enterTheConsole != "shopping time")
            {
                List<string> products = enterTheConsole.Split(' ').ToList();

                if (!answer.ContainsKey(products[1]))
                {
                    answer.Add(products[1], int.Parse(products[2]));
                }

                else
                {
                    answer[products[1]] += int.Parse(products[2]);
                }

                enterTheConsole = Console.ReadLine();
            }

            enterTheConsole = Console.ReadLine();

            while (enterTheConsole != "exam time")
            {
                List<string> products = enterTheConsole.Split(' ').ToList();

                if (!answer.ContainsKey(products[1]))
                {
                    Console.WriteLine($"{products[1]} doesn't exist");
                }

                else if (answer[products[1]] == 0)
                {
                    Console.WriteLine($"{products[1]} out of stock");
                }

                else if (answer[products[1]] < int.Parse(products[2]))
                {
                    answer[products[1]] = 0;

                }

                else
                {
                    answer[products[1]] -= int.Parse(products[2]);
                }

                enterTheConsole = Console.ReadLine();
            }

            foreach (var kvp in answer)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}