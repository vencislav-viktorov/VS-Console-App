using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Extract_sentences_by_keyword
{
    public class Extract_sentences_by_keyword
    {
        public static void Main()
        {
            string key = Console.ReadLine();

            string text = Console.ReadLine();

            Regex regex = new Regex($"\\b{key}\\b");

            string[] result = text
                .Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .Where(x => regex.IsMatch(x))
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
