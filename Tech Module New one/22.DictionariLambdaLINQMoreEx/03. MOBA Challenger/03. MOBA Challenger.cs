using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> playerPositionSkill = new Dictionary<string, Dictionary<string, int>>();

            while (command != "Season end")
            {
                if (command.Contains("->"))
                {
                    string[] tokens = command
                        .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string player = tokens[0];

                    string position = tokens[1];

                    int skill = int.Parse(tokens[2]);

                    if (!playerPositionSkill.ContainsKey(player))
                    {
                        playerPositionSkill.Add(player, new Dictionary<string, int>());
                    }

                    if (!playerPositionSkill[player].ContainsKey(position))
                    {
                        playerPositionSkill[player].Add(position, int.MinValue);
                    }

                    skill = Math.Max(playerPositionSkill[player][position], skill);

                    playerPositionSkill[player][position] = skill;

                }

                else if (command.Contains(" vs "))
                {
                    string[] tokens = command
                        .Split(new string[] { " vs " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string player1 = tokens[0];

                    string player2 = tokens[1];

                    if (playerPositionSkill.ContainsKey(player1) && playerPositionSkill.ContainsKey(player2))
                    {
                        bool stop = false;

                        foreach (var position in playerPositionSkill[player1])
                        {
                            foreach (var pos in playerPositionSkill[player2])
                            {
                                if (position.Key == pos.Key)
                                {
                                    stop = true;

                                    if (playerPositionSkill[player1].Values.Sum() > playerPositionSkill[player2].Values.Sum())
                                    {
                                        playerPositionSkill.Remove(player2);

                                        break;
                                    }

                                    else if (playerPositionSkill[player1].Values.Sum() < playerPositionSkill[player2].Values.Sum())
                                    {
                                        playerPositionSkill.Remove(player1);

                                        break;
                                    }
                                }
                            }

                            if (stop)
                            {
                                break;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var player in playerPositionSkill.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
