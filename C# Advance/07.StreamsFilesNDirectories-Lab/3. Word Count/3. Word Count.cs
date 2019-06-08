using System;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main()
        {
            var words = File.ReadAllText(@"../../../Resources/words.txt")
                .ToLower()
                .Split()
                .ToDictionary(word => word, word => 0);

            var text = File.ReadAllText(@"../../../Resources/text.txt")
                .ToLower()
                .Split(new[] { ',', ' ', '.', '?', '!', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in text)
            {
                if (words.ContainsKey(word))
                    words[word]++;
            }

            var output = words
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => kvp.Key + " - " + kvp.Value);

            File.WriteAllLines(@"Output.txt", output);
        }
    }
}
