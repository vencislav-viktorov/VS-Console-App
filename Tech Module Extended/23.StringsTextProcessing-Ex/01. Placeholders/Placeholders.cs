using System;

namespace _01.Placeholders
{
    public class Placeholders
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { '-', '>' }, 
                StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                var sentenceWithPlaceHolders = input[0].Trim();

                var wordsForReplace = input[1].Trim().Split(new[] { ' ', ',' }, 
                    StringSplitOptions.RemoveEmptyEntries);

                for (int index = 0; index < wordsForReplace.Length; index++)
                {
                    var elements = "{" + index + "}";

                    sentenceWithPlaceHolders = sentenceWithPlaceHolders.Replace(elements, wordsForReplace[index]);
                }

                Console.WriteLine(sentenceWithPlaceHolders);

                input = Console.ReadLine().Split(new[] { '-', '>' }, 
                    StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
