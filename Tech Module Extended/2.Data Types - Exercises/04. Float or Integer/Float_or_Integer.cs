using System;

namespace _04.Float_or_Integer
{
    public class Float_or_Integer
    {
        public static void Main()
        {
            double inputNumber = double.Parse(Console.ReadLine());

            if (inputNumber % 1 == 0)
            {
                Console.WriteLine(inputNumber);
            }

            else
            {
                Console.WriteLine(Math.Round(inputNumber));
            }
        }

    }
}