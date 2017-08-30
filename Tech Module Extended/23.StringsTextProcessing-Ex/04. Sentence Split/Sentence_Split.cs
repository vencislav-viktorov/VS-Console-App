using System;

namespace _04.Sentence_Split
{
    public class Sentence_Split
    {
        public static void Main()
        {
            var sentense = Console.ReadLine();

            var delimiter = Console.ReadLine();

            var currentPartsOfSentens = sentense.Replace(delimiter, ", ").ToString();

            Console.WriteLine($"[{currentPartsOfSentens}]");
        }
    }
}
