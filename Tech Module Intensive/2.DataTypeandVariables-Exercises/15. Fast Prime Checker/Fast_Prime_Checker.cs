using System;

namespace _15.Fast_Prime_Checker
{
    public class Fast_Prime_Checker
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;

                        break;
                    }
                }

                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
