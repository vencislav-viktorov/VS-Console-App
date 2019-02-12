using System;

namespace _10._Rage_Expenses
{
    public class Program
    {
        public static void Main()
        {
            decimal lostGames = decimal.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());
            decimal breakMoney = 0;


            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    breakMoney += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    breakMoney += mousePrice;
                }

                if (i % 6 == 0)
                {
                    breakMoney += keyboardPrice;
                }

                if (i % 12 == 0)
                {
                    breakMoney += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {breakMoney:f2} lv.");
        }
    }
}
