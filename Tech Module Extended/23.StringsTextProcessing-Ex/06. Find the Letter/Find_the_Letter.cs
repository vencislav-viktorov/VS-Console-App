using System;

namespace _06.Find_the_Letter
{
    public class FindLetter
    {
        public static void Main()
        {
            var stringThroughSearching = Console.ReadLine();

            var searchingSymbolAndThereOccurrence = Console.ReadLine().Split(' ');

            var symbol = searchingSymbolAndThereOccurrence[0];

            var occurrence = Convert.ToInt16(searchingSymbolAndThereOccurrence[1]);

            var occurrenceIndex = -1;

            for (int index = 0; index < occurrence; index++)
            {
                occurrenceIndex = stringThroughSearching.IndexOf(symbol, occurrenceIndex + 1);
            }

            Console.WriteLine(occurrenceIndex >= 0 ? $"{occurrenceIndex}" : "Find the letter yourself!");
        }
    }
}
