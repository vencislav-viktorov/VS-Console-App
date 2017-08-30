using System;

namespace _10.CountofNegativeElementsinArray
{
    public class CountofNegativeElementsinArray
    {
        public static void Main()
        {
            var counter = 0;

            var counterLines = Convert.ToInt32(Console.ReadLine());

            var currentNumber = 0;

            for (int i = 0; i < counterLines; i++)
            {
                currentNumber = Convert.ToInt32(Console.ReadLine());

                if (currentNumber < 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
