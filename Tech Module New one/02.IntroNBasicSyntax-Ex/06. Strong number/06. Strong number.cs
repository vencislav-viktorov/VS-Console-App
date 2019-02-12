using System;

namespace _06._Strong_number
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int numbercopy = number;
            int sumFactoriel = 0;

            while (number != 0)
            {
                int currentNumber = number % 10;
                number /= 10;

                int factoriel = 1;

                for (int i = 2; i <= currentNumber; i++)
                {
                    factoriel *= i;
                }

                sumFactoriel += factoriel;
            }

            if (sumFactoriel == numbercopy)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
