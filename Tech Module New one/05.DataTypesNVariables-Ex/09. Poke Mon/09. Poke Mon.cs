using System;

namespace _09._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distancePokePowerM = int.Parse(Console.ReadLine());
            int exhaustionFactoryY = int.Parse(Console.ReadLine());
            int countMission = 0;
            int isEqual50PercentOfPokePowerN = pokePowerN / 2;

            while (pokePowerN >= distancePokePowerM)
            {
                pokePowerN -= distancePokePowerM;
                countMission++;

                if (pokePowerN == isEqual50PercentOfPokePowerN && exhaustionFactoryY > 0)
                {
                    pokePowerN /= exhaustionFactoryY;
                }
            }

            Console.WriteLine($"{pokePowerN}");
            Console.WriteLine($"{countMission}");
        }
    }
}
