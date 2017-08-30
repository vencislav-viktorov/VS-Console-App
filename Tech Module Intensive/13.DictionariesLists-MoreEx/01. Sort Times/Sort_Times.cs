using System;
using System.Linq;

namespace _01.Sort_Times
{
    public class Sort_Times
    {
        public static void Main()
        {
            var times = Console.ReadLine().Split(' ');

            var orderedTimes = times.OrderBy(x => x);

            Console.WriteLine(string.Join(", ", orderedTimes));
        }
    }
}
