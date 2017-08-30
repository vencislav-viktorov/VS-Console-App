using System;

namespace _03.Exact_Sum_of_Real_Numbers
{
    public class Exact_Sum_of_Real_Numbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
