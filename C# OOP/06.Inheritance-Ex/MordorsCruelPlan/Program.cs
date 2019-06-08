namespace MordorsCruelPlan
{
    using MordorsCruelPlan.Foods;
    using MordorsCruelPlan.Moods;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var foodsEaten = new List<Food>();
            var foodFactory = new FoodFactory();
            var foods = Console.ReadLine()
                .Split();

            foreach (var food in foods)
            {
                var foodToAdd = foodFactory
                     .GetFood(food);

                foodsEaten.Add(foodToAdd);
            }

            var happinessFood = foodsEaten
                .Select(x => x == null ? -1 : x.Happiness)
                .Sum();

            Console.WriteLine(happinessFood);

            if (happinessFood < -5)
            {
                Console.WriteLine(nameof(Angry));
            }

            else if (happinessFood >= -5 && happinessFood <= 0)
            {
                Console.WriteLine(nameof(Sad));
            }

            else if (happinessFood >= 1 && happinessFood <= 15)
            {
                Console.WriteLine(nameof(Happy));
            }

            else if (happinessFood > 15)
            {
                Console.WriteLine(nameof(JavaScript));
            }
        }
    }
}