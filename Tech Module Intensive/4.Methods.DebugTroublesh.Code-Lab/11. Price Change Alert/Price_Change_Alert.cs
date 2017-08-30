using System;

namespace _11.Price_Change_Alert
{
    public class Price_Change_Alert
    {
        public static void Main()
        {
            int numberOfStockPrice = int.Parse(Console.ReadLine());

            double notificationLimit = double.Parse(Console.ReadLine());

            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStockPrice - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());

                double currentPercantage = GetPercentage(lastPrice, currentPrice);

                bool hasDifference = HasDifference(currentPercantage, notificationLimit);

                string message = GetNotification(currentPrice, lastPrice, currentPercantage, hasDifference);

                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        static string GetNotification(double currentPrice, double lastPrice, double difference, bool hasDifference)
        {
            string to = String.Empty;

            if (difference == 0)
            {
                to = string.Format("NO CHANGE: {0}", currentPrice);
            }

            else if (!hasDifference)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }

            else if (hasDifference && (difference > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }

            else if (hasDifference && (difference < 0))
            {
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }

            return to;
        }

        static bool HasDifference(double limit, double notificationLimit)
        {
            if (Math.Abs(limit) >= notificationLimit)
            {
                return true;
            }

            return false;
        }

        static double GetPercentage(double lastPrice, double currentPrice)
        {
            return (currentPrice - lastPrice) / lastPrice;
        }
    }
}
