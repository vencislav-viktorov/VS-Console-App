using System;
using System.Collections.Generic;
using System.IO;

namespace _04.Punctuation_Finder_fifth_way
{
    public class Punctuation_Finder_fifth_way
    {
        public static void Main()
        {
            string text = File.ReadAllText("sample_text.txt");

            char[] punctuations = { '.', ',', '!', '?', ':' };

            List<char> result = new List<char>();


            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < punctuations.Length; j++)
                {
                    if (text[i] == punctuations[j])
                    {
                        result.Add(text[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
