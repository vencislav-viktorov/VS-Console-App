using System;

namespace _12.Beer_Kegs
{
    public class Beer_Kegs
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double radius = 0;

            double height = 0;

            double maxVolume = 0;

            string winnerTeam = String.Empty;
            
            for (int i = 0; i < n; i++)
            {
                var model = Console.ReadLine();

                radius = double.Parse(Console.ReadLine());

                height = double.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;

                    winnerTeam = model;
                }
            }

            Console.WriteLine(winnerTeam);
        }
    }
}
