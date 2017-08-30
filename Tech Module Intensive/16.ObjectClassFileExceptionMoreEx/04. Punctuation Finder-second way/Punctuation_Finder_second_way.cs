using System.Linq;
using System.IO;

namespace _04.Punctuation_Finder_second_way
{
    public class Punctuation_Finder_second_way
    {
        public static void Main()
        {
            var text = File.ReadAllText("sample_text.txt");

            var chars = text.Where(c => new char[] { '.', ',', '?', '!', ':' }.Any(i => i == c)).ToArray();

            File.WriteAllText("output.txt", string.Join(", ", chars));
        }
    }
}
