using System;
using System.Text.RegularExpressions;

namespace _04.Happiness_Index
{
    public class Happiness_Index
    {
        public static void Main()
        {
            var happy = new Regex(@"([:;][\)\]\}\*D])|([\(\[\{\*c][:;])");

            var sad = new Regex(@"([:;][\(\[\{c])|([\)\]\}D][:;])");

            var feelings = Console.ReadLine();

            var nTimesHappy = happy.Matches(feelings).Count * 1.0;

            var nTimesSad = sad.Matches(feelings).Count * 1.0;

            var happynessIndex = nTimesHappy / nTimesSad;

            var smily = string.Empty;

            if (happynessIndex >= 2) { smily = ":D"; }

            else if (happynessIndex > 1) { smily = ":)"; }

            else if (happynessIndex == 1) { smily = ":|"; }

            else { smily = ":("; }

            Console.WriteLine($"Happiness index: {happynessIndex:f2} {smily}");

            Console.WriteLine($"[Happy count: {nTimesHappy}, Sad count: {nTimesSad}]");
        }
    }
}
