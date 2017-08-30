using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04.Punctuation_Finder_third_way
{
    public class Punctuation_Finder_third_way
    {
        public static void Main()
        {
            string text = File.ReadAllText("sample_text.txt");

            List<char> ponctuationMarks = new List<char>();

            //“.”, “,”, “!”, “?” and “:”.

            char[] marks = new char[] { '.', ',', '!', '?', ':' };

            ponctuationMarks = text.Where(x => marks.Contains(x)).ToList();

            File.WriteAllText("output.txt", string.Join(", ", ponctuationMarks));
        }
    }
}
