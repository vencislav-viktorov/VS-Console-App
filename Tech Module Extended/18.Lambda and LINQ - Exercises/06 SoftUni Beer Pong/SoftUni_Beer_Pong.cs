using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_SoftUni_Beer_Pong
{
    public class SoftUniBeerPong
    {
        static int score = 0;

        static string team = string.Empty;

        static string player = string.Empty;

        static Dictionary<string, Dictionary<string, int>> teams =
            new Dictionary<string, Dictionary<string, int>>();

        public static void Main()
        {
            ReadUntillStopTheGame(Console.ReadLine());

            PrintResultsByGivenOrder();
        }

        static void ReadUntillStopTheGame(string teamData)
        {
            if (teamData != "stop the game")
            {
                DivideAndRule(teamData);

                AddToTeamCollection();

                ReadUntillStopTheGame(Console.ReadLine());
            }

            else return;
        }

        static void DivideAndRule(string teamData)
        {
            var splitedTeamData = teamData.Split(new[] { '|' }, 
                StringSplitOptions.RemoveEmptyEntries);

            team = splitedTeamData[1];

            player = splitedTeamData[0];

            score = Convert.ToInt32(splitedTeamData[2]);
        }

        static void AddToTeamCollection()
        {
            if (areEnougthPlayers())
            {
                return;
            }

            if (!teams.ContainsKey(team))
            {
                teams[team] = new Dictionary<string, int>();
            }

            if (!teams[team].ContainsKey(player))
            {
                teams[team][player] = 0;
            }

            teams[team][player] = score;
        }

        static bool areEnougthPlayers()
        {
            if (teams.ContainsKey(team))
            {
                return teams[team].Values.Count == 3;
            }

            else return false;
        }

        static void PrintResultsByGivenOrder()
        {
            var teamCounter = 1;

            foreach (var team in teams
                .OrderByDescending(x => x.Value.Values.Sum()).Where(x => x.Value.Count > 2))
            {
                Console.WriteLine($"{teamCounter}. {team.Key}; Players:");

                foreach (var player in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{player.Key}: {player.Value}");
                }

                teamCounter++;
            }
        }
    }
}
