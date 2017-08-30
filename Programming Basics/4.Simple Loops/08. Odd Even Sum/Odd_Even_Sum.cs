using System;

namespace _08.Odd_Even_Sum
{
    class Odd_Even_Sum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int evensum = 0;

            int oddsum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evensum += num;
                }

                else
                {
                    oddsum += num;
                }
            }

            if (evensum == oddsum)
            {
                Console.WriteLine("Yes, sum = {0}", evensum);
            }

            else
            {
                int diff = Math.Abs(evensum - oddsum);

                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}
