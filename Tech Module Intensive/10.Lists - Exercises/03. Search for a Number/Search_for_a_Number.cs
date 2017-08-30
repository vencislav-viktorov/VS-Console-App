using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Search_for_a_Number
{
    public class Search_for_a_Number
    {
        public static void Main()
        {
            List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> lineOfCommands = Console.ReadLine().Split().Select(int.Parse).ToList();

            int takeThisMuchDigits = lineOfCommands[0];

            int removeThisMuchDigits = lineOfCommands[1];

            int checkThisOut = lineOfCommands[2];

            lineOfDigits.Take(takeThisMuchDigits);

            lineOfDigits.RemoveRange(0, removeThisMuchDigits);

            if (lineOfDigits.Contains(checkThisOut))
            {
                Console.WriteLine("YES!");
            }

            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
