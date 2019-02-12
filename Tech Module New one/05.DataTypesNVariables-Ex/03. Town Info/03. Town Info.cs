using System;

namespace _03._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int populationTown = int.Parse(Console.ReadLine());
            int areaTown = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {populationTown} and area {areaTown} square km.");
        }
    }
}
