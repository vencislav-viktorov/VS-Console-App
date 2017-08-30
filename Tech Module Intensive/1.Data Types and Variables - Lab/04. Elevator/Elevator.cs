using System;

namespace _04.Elevator
{
    public class Elevator
    {
        public static void Main()
        {
            int personsElevator = int.Parse(Console.ReadLine());

            int capacityElevator = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)personsElevator / capacityElevator);

            Console.WriteLine(courses);
        }
    }
}
