using System;

namespace _06.Diamond_Problem
{
    public class DiamondProblem
    {
        static int endIndex;

        static int startIndex;

        static int nextStartIndex;

        static string diamondSubstring;

        static string diamondsValue = string.Empty;

        public static void Main()
        {
            var someStringWithOrWithoutDiamonds = $@"{Console.ReadLine()}";

            FindAllDiamondsIn(someStringWithOrWithoutDiamonds);

            PrintResultForEachDiamontsValue();
        }

        static bool IsValidDiamond()
        {
            return startIndex >= 0 && endIndex >= 0 && startIndex < endIndex;
        }

        static void FindAllDiamondsIn(string someStringWithOrWithoutDiamonds)
        {
            endIndex = -1;

            startIndex = -1;

            for (int index = 0; index < someStringWithOrWithoutDiamonds.Length; index++)
            {
                diamondSubstring = string.Empty;

                endIndex = someStringWithOrWithoutDiamonds.IndexOf('>', endIndex + 1);

                startIndex = someStringWithOrWithoutDiamonds.IndexOf('<', startIndex + 1);

                nextStartIndex = someStringWithOrWithoutDiamonds.IndexOf('<', startIndex + 1);

                if (endIndex == -1 || startIndex == -1)
                {
                    return;
                }

                if (nextStartIndex < endIndex)
                {
                    startIndex = FindStartIndex(someStringWithOrWithoutDiamonds);
                }

                if (IsValidDiamond())
                {
                    diamondSubstring = someStringWithOrWithoutDiamonds.Substring(startIndex + 1, endIndex - startIndex);

                    if (diamondSubstring.Length > 0)
                    {
                        SumAllDigitsToTakeCurrentDiamondValue();
                    }
                }
            }
        }

        static int FindStartIndex(string someStringWithOrWithoutDiamonds)
        {
            var index = nextStartIndex;

            while (true)
            {
                nextStartIndex = index;

                index = someStringWithOrWithoutDiamonds.IndexOf('<', index + 1);

                if (index > endIndex || index == -1)
                {
                    break;
                }
            }

            return nextStartIndex;
        }

        static void SumAllDigitsToTakeCurrentDiamondValue()
        {
            var sum = 0;

            foreach (var symbol in diamondSubstring)
            {
                if (symbol >= '0' && symbol <= '9')
                {
                    sum += Convert.ToInt32($"{symbol}");
                }
            }

            diamondsValue += $"{sum} ";
        }

        static void PrintResultForEachDiamontsValue()
        {
            if (diamondsValue == string.Empty)
            {
                Console.WriteLine("Better luck next time");

                return;
            }

            foreach (var value in diamondsValue.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries))
            {
                Console.WriteLine($"Found {value} carat diamond");
            }
        }
    }
}
