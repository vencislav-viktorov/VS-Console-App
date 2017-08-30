using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    public class Valid_Usernames
    {
        public static void Main()
        {
            var pattern = @"(^|(?<=[ \/\\\(\)]))[A-Za-z]\w{2,24}($|(?=[ \/\\\(\)]))";

            var matches = Regex.Matches(Console.ReadLine(), pattern).Cast<Match>().ToList();

            var index = 0;

            var sum = 0;

            for (int i = 0; i < matches.Count - 1; i++)
            {
                var tempSum = matches[i].Length + matches[i + 1].Length;

                if (tempSum > sum)
                {
                    index = i;

                    sum = tempSum;
                }
            }

            Console.WriteLine(matches[index]);

            Console.WriteLine(matches[index + 1]);
        }
    }
}
