﻿using System;

namespace _01.Personal_Titles
{
    class Personal_Titles
    {
        static void Main()
        {
            var age = double.Parse(Console.ReadLine());

            string gender = Console.ReadLine();

            if (age < 16)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Master");
                }

                else if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
            }

            else
            {
                if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }

                else if (gender == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
