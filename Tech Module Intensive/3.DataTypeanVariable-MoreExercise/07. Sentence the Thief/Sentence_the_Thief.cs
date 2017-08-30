using System;

namespace _07.Sentence_the_Thief
{
    public class Sentence_the_Thief
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            long maxValue = 0L;

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

            double num = 0d;

            if (thiefsId < 0)
            {
                num = sbyte.MinValue;
            }

            else
            {
                num = sbyte.MaxValue;
            }

            double years = Math.Ceiling(thiefsId / num);

            Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2}",
                thiefsId, years, years > 1 ? "years" : "year");
        }
    }
}
