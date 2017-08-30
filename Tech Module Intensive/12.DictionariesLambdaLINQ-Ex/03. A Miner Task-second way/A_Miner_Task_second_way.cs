using System;
using System.Collections.Generic;

namespace _03.A_Miner_Task_second_way
{
    public class A_Miner_Task_second_way
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, int> resourses = new Dictionary<string, int>();

            int stringCounter = 1;

            string key = "";

            int value = 0;

            while (input != "stop")
            {

                if (stringCounter % 2 != 0)
                {
                    if (!resourses.ContainsKey(input))
                    {
                        resourses[input] = 0;
                    }

                    key = input;
                }

                else
                {
                    value = int.Parse(input);

                    resourses[key] += value;
                }

                stringCounter++;

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> pair in resourses)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
