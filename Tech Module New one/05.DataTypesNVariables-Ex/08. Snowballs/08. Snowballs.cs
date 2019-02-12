using System;
using System.Numerics;

namespace _08._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsCount = int.Parse(Console.ReadLine());

            double snowballSnowSave = 0;
            double snowballTimeSave = 0;
            double snowballQualitySave = 0;
            BigInteger maxSnowballValue = 0;
            
            for (int i = 0; i < snowballsCount; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                short snowballQuality = short.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                
                if (snowballValue > maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;
                    snowballSnowSave = snowballSnow;
                    snowballTimeSave = snowballTime;
                    snowballQualitySave = snowballQuality;
                }
            }

            Console.WriteLine($"{snowballSnowSave} : {snowballTimeSave} = {maxSnowballValue} ({snowballQualitySave})");
        }
    }
}
