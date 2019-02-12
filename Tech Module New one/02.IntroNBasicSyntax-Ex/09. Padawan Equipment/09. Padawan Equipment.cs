using System;

namespace _09._Padawan_Equipment
{
    public class Program
    {
        public static void Main()
        {
            decimal totalMoney = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal ropePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            decimal totalPriceSabers = lightsaberPrice * Math.Ceiling(studentsCount * 1.1m);
            decimal totalPriceRobes = ropePrice * studentsCount;

            int beltsLeft = studentsCount % 6;
            int beltsCount = studentsCount / 6 * 5 + beltsLeft;

            decimal totalPriceBelts = beltsCount * beltPrice;

            decimal totalSpentMoney = totalPriceBelts + totalPriceRobes + totalPriceSabers;

            if (totalSpentMoney <= totalMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSpentMoney:f2}lv.");
            }

            else
            {
                Console.WriteLine($"Ivan Cho will need {totalSpentMoney - totalMoney:f2}lv more.");
            }
        }
    }
}
