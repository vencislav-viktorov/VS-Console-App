using System;

namespace _02.Choose_a_Drink_2._0
{
    public class Program
    {
        public static void Main()
        {
            string person = Console.ReadLine();

            double count = double.Parse(Console.ReadLine());

            switch (person)
            {
                case "Athlete":
                    Console.WriteLine("The Athlete has to pay {0:f2}.", count * 0.7);
                    break;

                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("The {0} has to pay {1:f2}.", person, count * 1.0);
                    break;

                case "SoftUni Student":
                    Console.WriteLine("The SoftUni Student has to pay {0:f2}.", count * 1.7);
                    break;

                default:
                    Console.WriteLine("The {0} has to pay {1:f2}.",person, count * 1.2);
                    break;
            }
        }
    }
}
