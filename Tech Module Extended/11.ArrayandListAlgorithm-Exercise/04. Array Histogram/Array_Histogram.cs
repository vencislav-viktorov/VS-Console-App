using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Array_Histogram
{
    public class Array_Histogram
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            //Holds Unique Words

            var foundWords = new List<string>();

            //Holds Word Occurences

            var wordCount = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currendWord = words[i];

                if (foundWords.Contains(currendWord))
                {
                    int wordIndex = foundWords.IndexOf(currendWord);

                    wordCount[wordIndex]++;
                }

                else
                {
                    foundWords.Add(currendWord);

                    wordCount.Add(1);
                }
            }

            var hasSwapped = true;

            //Bubble sord

            while (hasSwapped)
            {
                hasSwapped = false;

                for (int i = 0; i < wordCount.Count - 1; i++)
                {
                    //Bubble

                    if (wordCount[i] < wordCount[i + 1])
                    {
                        var temp = wordCount[i];

                        wordCount[i] = wordCount[i + 1];

                        wordCount[i + 1] = temp;

                        var tempWord = foundWords[i];

                        foundWords[i] = foundWords[i + 1];

                        foundWords[i + 1] = tempWord;

                        hasSwapped = true;
                    }
                }
            }

            for (int i = 0; i < foundWords.Count; i++)
            {
                var currentPercentage = (wordCount[i] * 100.0) / words.Length;

                Console.WriteLine("{0} -> {1} times ({2:F2}%)", foundWords[i], wordCount[i], currentPercentage);
            }
        }
    }
}
