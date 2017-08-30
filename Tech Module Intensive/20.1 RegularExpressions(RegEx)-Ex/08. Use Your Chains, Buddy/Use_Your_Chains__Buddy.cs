using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08.Use_Your_Chains__Buddy
{
    public class Use_Your_Chains__Buddy
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var matches = Regex.Matches(text, @"<p>(.*?)</p>")
                .Cast<Match>()
                .Select(x => Regex.Replace(x.Groups[1].Value, @"[^a-z0-9]+", " "))
                .Select(x => Regex.Replace(x, @"([a-z])", m => ((char)(m.Value.
                ToCharArray()
                .Select(c => { if (c <= 'm') return (char)(c + 13); return (char)(c - 13); })
                .Last())).ToString()))
                .ToList();

            Console.WriteLine(string.Join("", matches));
        }
    }
}
