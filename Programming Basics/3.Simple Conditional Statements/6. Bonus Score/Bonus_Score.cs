using System;

namespace _6.Bonus_Score
{
    class Bonus_Score
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            double bonus = 0;

            if (number <= 100)
            {
                bonus = 5;
            }

            if (number > 100)
            {
                bonus = 0.2 * number;
            }

            if (number > 1000)
            {
                bonus = 0.1 * number;
            }

            if (number % 2 == 0)
            {
                bonus++;
            }

            if (number % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);

            Console.WriteLine(number + bonus);
        }
    }
}
