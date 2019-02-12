using System;

namespace _04._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double peopleCount = double.Parse(Console.ReadLine());
            double elevatorCount = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(peopleCount / elevatorCount));           
        }
    }
}
