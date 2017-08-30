using System;

namespace _06.Catch_the_Thief
{
    public class Catch_the_Thief
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            long maxValue = 0;

            switch (type)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;

                case "int":
                    maxValue = int.MaxValue;
                    break;

                case "long":
                    maxValue = long.MaxValue;
                    break;
            }

            int n = int.Parse(Console.ReadLine());

            long thiefsId = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                long tempID = long.Parse(Console.ReadLine());

                if (tempID > thiefsId && tempID <= maxValue)
                {
                    thiefsId = tempID;
                }
            }

            Console.WriteLine(thiefsId);
        }
    }
}
