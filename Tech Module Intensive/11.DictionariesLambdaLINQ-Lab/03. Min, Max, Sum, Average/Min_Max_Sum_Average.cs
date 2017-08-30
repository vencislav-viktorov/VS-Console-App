using System;
using System.Linq;

namespace _03.Min__Max__Sum__Average
{
    public class Min_Max_Sum_Average
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());

            int[] answer = new int[limit];

            for (int cycle = 0; cycle < limit; cycle++)
            {
                answer[cycle] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {answer.Sum()}");

            Console.WriteLine($"Min = {answer.Min()}");

            Console.WriteLine($"Max = {answer.Max()}");

            Console.WriteLine($"Average = {answer.Average()}");
        }
    }
}
