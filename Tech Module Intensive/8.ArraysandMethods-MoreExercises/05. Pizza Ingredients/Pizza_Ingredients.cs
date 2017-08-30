using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Pizza_Ingredients
{
    public class Pizza_Ingredients
    {
        public static void Main()
        {
            var ingredients = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var maxIngredientLenght = int.Parse(Console.ReadLine());

            int ingredientsCount = 0;

            var addedIngredients = new List<string>();

            for (int i = 0; i < ingredients.Length && ingredientsCount < 10; i++)
            {
                if (ingredients[i].Length == maxIngredientLenght)
                {
                    addedIngredients.Add(ingredients[i]);

                    Console.WriteLine($"Adding {ingredients[i]}.");

                    ingredientsCount++;
                }
            }

            Console.WriteLine($"Made pizza with total of {ingredientsCount} ingredients.");

            Console.WriteLine($"The ingredients are: {string.Join(", ", addedIngredients)}.");
        }
    }
}
