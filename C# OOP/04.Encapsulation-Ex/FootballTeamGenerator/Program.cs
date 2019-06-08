namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var teams = new List<Team>();

            while (input != "END")
            {
                var tokens = input
                    .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];

                switch (command)
                {
                    case "Team":
                        var teamName = tokens[1];
                        teams.Add(new Team(teamName));
                        break;

                    case "Add":
                        teamName = tokens[1];
                        var playerName = tokens[2];
                        var endurance = int.Parse(tokens[3]);
                        var sprint = int.Parse(tokens[4]);
                        var dribble = int.Parse(tokens[5]);
                        var passing = int.Parse(tokens[6]);
                        var shooting = int.Parse(tokens[7]);

                        var teamExists = teams
                            .Any(t => t.Name == teamName);
                        Team team;

                        if (!teamExists)
                        {
                            Console.WriteLine($"{nameof(Team)} {teamName} does not exist.");
                        }

                        else
                        {
                            try
                            {
                                team = teams
                                    .Where(t => t.Name == teamName)
                                    .First();
                                var player = new Player(
                                    playerName,
                                    endurance,
                                    sprint,
                                    dribble,
                                    passing,
                                    shooting);
                                team.AddPlayer(player);
                            }

                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;

                    case "Remove":
                        teamName = tokens[1];
                        team = teams
                            .Where(t => t.Name == teamName)
                            .First();
                        playerName = tokens[2];

                        try
                        {
                            team.RemovePlayer(playerName);
                        }

                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "Rating":
                        teamName = tokens[1];
                        teamExists = teams
                            .Any(t => t.Name == teamName);

                        if (!teamExists)
                        {
                            Console.WriteLine($"{nameof(Team)} {teamName} does not exist.");
                        }

                        else
                        {
                            team = teams
                                .Where(t => t.Name == teamName)
                                .First();
                            Console.WriteLine($"{teamName} - {team.Rating()}");
                        }
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}