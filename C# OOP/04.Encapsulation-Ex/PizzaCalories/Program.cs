namespace PizzaCalories
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var pizzaArgs = Console.ReadLine()
                    .Split();

                var pizzaName = pizzaArgs[1];

                var doughArgs = Console.ReadLine()
                    .Split();

                var doughFlourType = doughArgs[1];
                var doughBakingTechnique = doughArgs[2];
                var weight = double.Parse(doughArgs[3]);

                var dough = new Dough(doughFlourType, doughBakingTechnique, weight);

                var pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    var toppingArgs = input
                        .Split();

                    var toppingType = toppingArgs[1];
                    var weightTopping = double.Parse(toppingArgs[2]);

                    var topping = new Topping(toppingType, weightTopping);

                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories().ToString("f2")} Calories.");
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}