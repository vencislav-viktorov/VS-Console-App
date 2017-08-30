using System;

namespace _01.Choose_a_Drink
{
    public class Choose_a_Drink
    {
        public static void Main()
        {
            string person = Console.ReadLine();

            switch (person)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;

                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;

                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;

                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
