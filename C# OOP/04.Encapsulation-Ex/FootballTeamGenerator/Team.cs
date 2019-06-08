namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A {nameof(this.name)} should not be empty.");
                }

                this.name = value;
            }
        }

        public int Rating()
        {
            if (this.players.Count == 0)
            {
                return 0;
            }

            return (int)Math.Round(this.players.Select(p => p.Skill()).Sum() / (double)this.players.Count);
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            var containsPlayer = this.players
                .Any(p => p.Name == playerName);

            if (!containsPlayer)
            {
                throw new ArgumentException($"{nameof(Player)} {playerName} is not in {this.name} team.");
            }

            var player = this.players
                .Where(p => p.Name == playerName)
                .First();
            this.players.Remove(player);
        }
    }
}
