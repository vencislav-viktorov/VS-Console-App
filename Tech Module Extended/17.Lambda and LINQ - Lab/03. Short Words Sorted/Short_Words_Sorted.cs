using System;
using System.Linq;

namespace _03.Short_Words_Sorted
{
    public class Short_Words_Sorted
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Select(w => w.ToLower())
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
