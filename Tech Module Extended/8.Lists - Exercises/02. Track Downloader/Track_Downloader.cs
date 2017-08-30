using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Track_Downloader
{
    public class Track_Downloader
    {
        public static void Main()
        {
            var blackListedWords = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var fileNames = Console.ReadLine();

            var result = new List<string>();

            while (fileNames != "end")
            {
                result.Add(fileNames);

                for (int j = 0; j < blackListedWords.Count; j++)
                {
                    if (fileNames.Contains(blackListedWords[j]))
                    {
                        result.RemoveAt(result.Count - 1);
                        break;
                    }
                }

                fileNames = Console.ReadLine();
            }

            result.Sort();

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
