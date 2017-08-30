using System;
using System.Linq;

namespace _04.Array_Data
{
    public class Array_Data
    {
        public static void Main()
        {
            var givenArray = Console.ReadLine().Split(' ')
            .Select(x => Convert.ToInt64(x)).ToList();

            var average = givenArray.Average();

            var currentArray = givenArray.Where(x => x >= average).ToList();

            var command = Console.ReadLine();

            if (command == "Min")
            {
                Console.WriteLine(currentArray.Min());
            }

            else if (command == "Max")
            {
                Console.WriteLine(currentArray.Max());
            }

            else
            {
                Console.WriteLine(string.Join(" ", currentArray.OrderBy(x => x)));
            }
        }
    }
}
