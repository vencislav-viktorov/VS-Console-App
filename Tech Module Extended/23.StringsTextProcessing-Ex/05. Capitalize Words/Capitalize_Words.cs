using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Capitalize_Words
{
    public class Capitalize_Words
    {
        public static void Main()
        {
            var symbols = new char[] { '.', ',', '-', '_', '!', '"', '?', ':', ';', '(', ')', '{', '}', '[', ']', '§'

            , '$', '%', '&', '/', '\\', '=', '|', '^', '°', '*', '#', '+', '~', '²', '³', '<', '>', ' '};

            var currentSentense = Console.ReadLine().ToLower().
                Split(symbols, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (currentSentense[0] != "end")
            {
                var newSentence = new List<string>();

                foreach (var symbol in currentSentense)
                {
                    var newWord = string.Empty; ;

                    for (int singht = 0; singht < symbol.Length; singht++)
                    {
                        var currentChar = symbol[singht].ToString();

                        if (singht == 0)
                        {
                            currentChar = symbol[singht].ToString().ToUpper();
                        }

                        newWord += currentChar;
                    }

                    newSentence.Add(newWord);
                }

                Console.WriteLine(string.Join(", ", newSentence));

                currentSentense = Console.ReadLine().ToLower().Split(symbols, 
                    StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        }
    }
}
