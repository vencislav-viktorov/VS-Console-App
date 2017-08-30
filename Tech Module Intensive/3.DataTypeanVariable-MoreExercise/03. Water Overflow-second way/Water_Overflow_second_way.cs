using System;

namespace _03.Water_Overflow_second_way
{
    public class Water_Overflow_second_way
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int alllitres = 0;

            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());

                if (alllitres + litres <= 255)
                {
                    alllitres += litres;
                }

                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(alllitres);
        }
    }
}
