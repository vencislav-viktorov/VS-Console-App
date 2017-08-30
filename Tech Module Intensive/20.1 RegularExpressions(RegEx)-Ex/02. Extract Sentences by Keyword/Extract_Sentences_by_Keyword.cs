using System;
using System.Text.RegularExpressions;

namespace _02.Extract_Sentences_by_Keyword
{
    public class Extract_Sentences_by_Keyword
    {
        public static void Main()
        {
            var flag = Console.ReadLine();

            var input = Console.ReadLine();

            var pattern = @"(^|(?<=[!\?\.]\s))[^!\?\.]*\W" + flag + @"\W[^!\?\.]*(?=[!\?\.])";

            MatchCollection sentences = Regex.Matches(input, pattern);

            foreach (Match sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
