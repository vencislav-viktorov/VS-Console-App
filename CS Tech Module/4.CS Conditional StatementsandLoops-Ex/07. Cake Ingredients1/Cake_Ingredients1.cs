using System;

namespace _07.Cake_Ingredients1
{
    public class Cake_Ingredients1
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int counter = 0;

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");

                input = Console.ReadLine();

                counter++;
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}