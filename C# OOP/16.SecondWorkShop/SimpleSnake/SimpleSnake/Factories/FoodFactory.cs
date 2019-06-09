namespace SimpleSnake.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using SimpleSnake.GameObjects;
    using SimpleSnake.GameObjects.Foods;

    public static class FoodFactory 
    {
        private static Random random;

        static FoodFactory()
        {
            random = new Random();
        }

        public static Food GetRandomFood(int boardWidth, int boardHeight)
        {
            List<Type> foodType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.BaseType == typeof(Food))
                .ToList();

            Type currentFoodType = foodType[random.Next(0, foodType.Count)];

            int cordinateX = random.Next(1, boardWidth - 1);
            int cordinateY = random.Next(1, boardHeight - 1);

            Cordinate foodCordinate = new Cordinate(cordinateX, cordinateY);

            return Activator
                .CreateInstance(currentFoodType, new object[] { foodCordinate }) as Food;
        }
    }
}