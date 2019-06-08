using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main()
        {
            var words = new List<string>();

            using (var wordReader = new StreamReader(@"../../../Resources/words.txt"))
            {
                string line;

                while ((line = wordReader.ReadLine()) != null)
                {
                    var splitedLine = line
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.ToLower())
                        .ToArray();

                    words.AddRange(splitedLine);
                }
            }

            var wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordsCount.ContainsKey(word) == false)
                {
                    wordsCount[word] = 0;
                }
            }

            using (var reader = new StreamReader(@"../../../Resources/text.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string symbols = " ";

                    foreach (var @char in line)
                    {
                        if (char.IsPunctuation(@char) && @char != '\'')
                        {
                            symbols += @char;
                        }
                    }

                    var splitedLine = line
                        .ToLower()
                        .Split(symbols.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in splitedLine)
                    {
                        if (wordsCount.ContainsKey(word))
                        {
                            wordsCount[word]++;
                        }
                    }
                }
            }

            var sortedDictionary = wordsCount
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            using (var readerResult = new StreamReader(@"../../../Resources/expectedResult.txt"))
            {
                bool isSame = true;

                foreach (var kvp in sortedDictionary)
                {
                    string output = $"{kvp.Key} - {kvp.Value}";

                    string line = readerResult.ReadLine();

                    if (output != line)
                    {
                        isSame = false;
                        break;
                    }
                }

                if (isSame)
                {
                    Console.WriteLine(true);
                }
            }

            using (var writer = new StreamWriter(@"../../../Resources/actualResult.txt"))
            {
                foreach (var kvp in sortedDictionary)
                {
                    string output = $"{kvp.Key} - {kvp.Value}";

                    writer.WriteLine(output);
                }
            }
        }
    }
}
