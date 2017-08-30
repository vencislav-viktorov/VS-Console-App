using System;

namespace _08.Calories_Counter
{
    public class Calories_Counter
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int cheese = 500;

            int tomatoSause = 150;

            int salami = 600;

            int peper = 50;

            int calories = 0;

            for (int i = 0; i < number; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        calories += cheese;
                        break;

                    case "tomato sauce":
                        calories += tomatoSause;
                        break;

                    case "salami":
                        calories += salami;
                        break;

                    case "pepper":
                        calories += peper;
                        break;

                    default:
                        continue;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}