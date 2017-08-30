using System;

namespace _03.Water_Overflow
{
    public class Water_Overflow
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int alllitres = 0;

            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());

                alllitres += litres;

                if (alllitres > 255)
                {
                    alllitres -= litres;

                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine($"{alllitres}");
        }
    }
}
