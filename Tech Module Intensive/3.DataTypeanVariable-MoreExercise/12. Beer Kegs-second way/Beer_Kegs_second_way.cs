using System;

namespace _12.Beer_Kegs_second_way
{
    public class Beer_Kegs_second_way
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double maxVolume = double.MinValue;

            string maxKegModel = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string currentModel = Console.ReadLine();

                double currentRadius = double.Parse(Console.ReadLine());

                double currentHeight = double.Parse(Console.ReadLine());

                double currentVolume = Math.PI * currentRadius * currentRadius * currentHeight;

                if (currentVolume > maxVolume)
                {
                    maxVolume = currentVolume;

                    maxKegModel = currentModel;
                }
            }

            Console.WriteLine(maxKegModel);
        }
    }
}