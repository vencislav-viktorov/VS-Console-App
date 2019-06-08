using System;
using System.Text.RegularExpressions;

namespace Chore_Wars
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var patternDishes = @"(?<=<)[a-z0-9]+(?=>)";
            var patternCleaning = @"(?<=\[)[A-Z0-9]+(?=\])";
            var patternLaundry = @"(?<={).+(?=})";
            var numberPattern = @"\d";

            var timeDishes = 0;
            var timeCleaning = 0;
            var timeLaundry = 0;
            var totalTime = 0;

            while (input != "wife is happy")
            {
                var dishesMatch = Regex.Match(input, patternDishes);
                var cleaningMatch = Regex.Match(input, patternCleaning);
                var laundryMatch = Regex.Match(input, patternLaundry);

                if (dishesMatch.Success)
                {
                    var dishesString = dishesMatch.ToString();

                    MatchCollection numbers = Regex.Matches(dishesString, numberPattern);

                    foreach (Match match in numbers)
                    {
                        var minutes = int.Parse(match.ToString());
                        timeDishes += minutes;
                    }
                }

                else if (cleaningMatch.Success)
                {
                    var cleaningString = cleaningMatch.ToString();

                    MatchCollection numbers = Regex.Matches(cleaningString, numberPattern);

                    foreach (Match match in numbers)
                    {
                        var minutes = int.Parse(match.ToString());
                        timeCleaning += minutes;
                    }
                }

                else if (laundryMatch.Success)
                {
                    var laundryString = laundryMatch.ToString();

                    MatchCollection numbers = Regex.Matches(laundryString, numberPattern);
                    
                    foreach (Match match in numbers)
                    {
                        var minutes = int.Parse(match.ToString());
                        timeLaundry += minutes;
                    }
                }

                input = Console.ReadLine();
            }

            totalTime = timeDishes + timeCleaning + timeLaundry;

            Console.WriteLine($"Doing the dishes - {timeDishes} min.");
            Console.WriteLine($"Cleaning the house - {timeCleaning} min.");
            Console.WriteLine($"Doing the laundry - {timeLaundry} min.");
            Console.WriteLine($"Total - {totalTime} min.");
        }
    }
}