using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04.Punctuation_Finder_forth_way
{
    public class Punctuation_Finder_forth_way
    {
        public static void Main()
        {
            const string filePathAndName = "../../sample_text.txt";

            var punctuations = ".,!?:".ToCharArray();

            var textArray = File.ReadAllText(filePathAndName).ToCharArray();

            var result = new List<char>();

            foreach (var ch in textArray)
            {
                if (punctuations.Contains(ch))
                {
                    result.Add(ch);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
