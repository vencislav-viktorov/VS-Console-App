using System;

namespace _12.Volleyball_second_way
{
    class Volleyball_second_way
    {
        static void Main()
        {
            string year = Console.ReadLine();

            int weeksReturnHome = int.Parse(Console.ReadLine());

            int happyDays = int.Parse(Console.ReadLine());

            float numGames = (weeksReturnHome * 2f / 3f) + ((48 - happyDays) * 3f / 4f) + happyDays;
            
            if (year == "leap")
            {
                numGames *= 1.15f;
            }

            Console.WriteLine((int)numGames);
        }
    }
}
