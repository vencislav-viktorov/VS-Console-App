using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Points_Counter
{
    public class PointsCounter
    {
        static string team;

        static string name;

        static int score;

        static Dictionary<string, Dictionary<string, int>> teamsPlayersScore =
            new Dictionary<string, Dictionary<string, int>>();

        public static void Main()
        {
            ReadNextInputLineFrom(Console.ReadLine());

            PrintResultFromTeamsPlayersScoreByGivenOrder();
        }

        static void PrintResultFromTeamsPlayersScoreByGivenOrder()
        {
            foreach (var item in teamsPlayersScore.OrderByDescending(x => x.Value.Sum(p => p.Value)))
            {
                Console.WriteLine($"{item.Key} => {item.Value.Sum(x => x.Value)}");

                var playerWithMostPoints = item.Value.OrderByDescending(x => x.Value).First().Key;

                Console.WriteLine($"Most points scored by {playerWithMostPoints}");
            }
        }

        static void ReadNextInputLineFrom(string input)
        {
            if (input != "Result")
            {
                SplitCurrent(input);

                ParsToTeamPlayerScoreColection();

                ReadNextInputLineFrom(Console.ReadLine());
            }

            else return;
        }

        static void SplitCurrent(string input)
        {
            var splited = input.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

            RemoveAllFalseSymbolsFrom(splited);

            if (splited[0] == splited[0].ToUpper())
            {
                team = splited[0];

                name = splited[1];
            }

            else
            {
                team = splited[1];

                name = splited[0];
            }

            score = Convert.ToInt32(splited[2]);
        }

        static void RemoveAllFalseSymbolsFrom(string[] splited)
        {
            for (int index = 0; index < splited.Length; index++)
            {
                splited[index] = splited[index].Replace("@", string.Empty);

                splited[index] = splited[index].Replace("%", string.Empty);

                splited[index] = splited[index].Replace("$", string.Empty);

                splited[index] = splited[index].Replace("*", string.Empty);
            }
        }

        static void ParsToTeamPlayerScoreColection()
        {
            if (!teamsPlayersScore.ContainsKey(team))
            {
                teamsPlayersScore[team] = new Dictionary<string, int>();
            }

            if (!teamsPlayersScore[team].ContainsKey(name))
            {
                teamsPlayersScore[team][name] = 0;
            }

            teamsPlayersScore[team][name] = score;
        }
    }
}