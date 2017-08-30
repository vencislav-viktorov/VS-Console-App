using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04.Punctuation_Finder
{
    //,, ,, ., ,, ., ., ,, !, ,, ,, :, ,, ., ,, ,, ,, ,, ., ,, ,, ?, ,, ?, ,, ,, ., ,, ,, ,, ,, ., ,, ,, ., ,, ,, ?, ,, ?, ,, ,, ., ., ,, ,, ,, ., ., ,, ., ,, ,, ,, :, ., ., ,, ,, ., ., :, ,, .
    public class Punctuation_Finder
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");

            char[] symbols = new[] { '.', ',', '!', '?', ':' };

            var punctuationsList = new List<char>();

            foreach (var word in text)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (symbols.Contains(word[i]))
                    {
                        punctuationsList.Add(word[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", punctuationsList));
        }
    }
}
