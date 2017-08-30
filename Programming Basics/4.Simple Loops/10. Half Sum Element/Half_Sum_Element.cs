using System;

namespace _10.Half_Sum_Element
{
    class Half_Sum_Element
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            if (sum == 2 * max)
            {
                Console.WriteLine("Yes");

                Console.WriteLine("Sum = {0}", max);
            }

            else
            {
                var diff = Math.Abs(2 * max - sum);

                Console.WriteLine("No");

                Console.WriteLine("Diff = {0}", diff);
            }
        }
    }
}
