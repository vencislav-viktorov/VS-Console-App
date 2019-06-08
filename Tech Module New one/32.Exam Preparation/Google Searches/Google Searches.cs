using System;

namespace Google_Searches
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalDays = double.Parse(Console.ReadLine());

            double numberOfUsers = double.Parse(Console.ReadLine());

            double moneyPerSearch = double.Parse(Console.ReadLine());

            double totalMoney = 0;

            int count = 0;

            for (int i = 0; i < numberOfUsers; i++)
            {
                double wordLength = double.Parse(Console.ReadLine());

                count++;

                if (wordLength == 1)
                {
                    double money = moneyPerSearch;

                    if (count % 3 == 0)
                    {
                        money *= 3;
                    }

                    money *= 2;

                    totalMoney += money;
                }

                else if (wordLength > 1 && wordLength <= 5)
                {
                    double money = moneyPerSearch;

                    if (count % 3 == 0)
                    {
                        money *= 3;
                    }
                    
                    totalMoney += money;
                }
            }

            totalMoney *= totalDays;

            Console.WriteLine($"Total money earned for {totalDays} days: {totalMoney:f2}");
        }
    }
}
