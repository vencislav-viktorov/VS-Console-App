using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Morse_Code_Upgraded
{
    public class Morse_Code_Upgraded
    {
        public static void Main()
        {
            var code = Console.ReadLine().Split('|').ToList();

            var msg = new StringBuilder();

            var patternSingles = @"(?<zero>[0])|(?<one>[1])";

            var patternMulti = @"(0{2,})|(1{2,})";

            foreach (var letter in code)
            {
                var characterCode = 0;

                var matchSingles = Regex.Matches(letter, patternSingles);

                var matchMulti = Regex.Matches(letter, patternMulti);

                //var num = matchSingles.Cast<Match>().Where(x => x.Groups["one"].Length != 0).Count();
                foreach (Match match in matchSingles)
                {
                    if (match.Value == "0") characterCode += 3;

                    else characterCode += 5;
                }

                foreach (Match match in matchMulti)
                {
                    characterCode += match.Value.Length;
                }

                msg.Append((char)characterCode);
            }

            Console.WriteLine(msg);
        }
    }
}
