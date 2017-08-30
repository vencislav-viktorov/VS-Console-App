using System;

namespace _07.Left_and_Right_Sum
{
    class Left_and_Right_Sum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int leftsum = 0;

            int rightsum = 0;

            for (int i = 0; i < (2 * n); i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    leftsum += num;
                }

                else
                {
                    rightsum += num;
                }
            }
            
            if (leftsum == rightsum)
            {
                Console.WriteLine("Yes, sum = {0}", leftsum);
            }
            
            else
            {
                int diff = Math.Abs(leftsum - rightsum);

                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}
