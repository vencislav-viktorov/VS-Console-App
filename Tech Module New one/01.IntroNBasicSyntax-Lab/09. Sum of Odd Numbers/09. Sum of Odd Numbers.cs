using System;

namespace _09._Sum_of_Odd_Numbers
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(count);
                sum += count;
                count += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
