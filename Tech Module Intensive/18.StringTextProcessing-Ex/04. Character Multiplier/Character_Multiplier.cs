using System;

namespace _04.Character_Multiplier
{
    public class Character_Multiplier
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string lineOne = input[0];

            string lineTwo = input[1];

            int minL = Math.Min(lineOne.Length, lineTwo.Length);

            int sum = 0;

            for (int i = minL - 1; i >= 0; i--)
            {
                sum += lineTwo[i] * lineOne[i];
            }

            string rest = String.Empty;

            if (lineOne.Length > lineTwo.Length)
            {
                rest = lineOne.Substring(minL);
            }

            else
            {
                rest = lineTwo.Substring(minL);
            }

            foreach (char chara in rest)
            {
                sum += chara;
            }

            Console.WriteLine(sum);
        }
    }
}
