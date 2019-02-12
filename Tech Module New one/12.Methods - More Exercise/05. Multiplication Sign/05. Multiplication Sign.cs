using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNegativeNumbers = 0;

            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }

                else if (number < 0)
                {
                    countNegativeNumbers++;
                }
            }

            if (countNegativeNumbers % 2 == 0)
            {
                Console.WriteLine("positive");
            }

            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
