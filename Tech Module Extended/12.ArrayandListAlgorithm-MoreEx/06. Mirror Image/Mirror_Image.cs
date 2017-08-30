﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Mirror_Image
{
    public class Mirror_Image
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();

            while (true)
            {
                string number = Console.ReadLine();

                if (number == "Print")
                {
                    break;
                }

                int index = int.Parse(number);

                List<string> before = new List<string>();

                for (int i = 0; i < input.Count; i++)
                {
                    if (i < index)
                    {
                        before.Insert(0, input[i]);
                    }

                    if (i == index)
                    {
                        before.Add(input[i]);
                    }
                }

                for (int y = input.Count - 1; y > index; y--)
                {
                    before.Add(input[y]);
                }

                input = before;
            }

            Console.WriteLine("{0}", string.Join(" ", input));
        }
    }
}
