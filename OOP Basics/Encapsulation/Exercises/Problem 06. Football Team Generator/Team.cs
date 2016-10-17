namespace Problem_06.Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Team
    {
        private string name;

        internal Team(string name)
        {
            this.Name = name;
            this.Players = new Dictionary<string, Player>();
        }

        internal int Rating => this.CalculateRating();

        internal Dictionary<string, Player> Players { get; }

        internal string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty. ");
                }

                this.name = value;
            }
        }

        internal void AddPlayer(string name, Player player)
        {
            this.Players.Add(name, player);
        }

        internal void RemovePlayer(string name)
        {
            if (!this.Players.ContainsKey(name))
            {
                throw new InvalidOperationException($"Player {name} is not in {this.Name} team.");
            }
            this.Players.Remove(name);
        }

        private int CalculateRating()
        {
            return this.Players.Count > 0 ? this.Players.Values.Sum(player => player.AverageSkill) / this.Players.Count: 0;
        }
    }
}
