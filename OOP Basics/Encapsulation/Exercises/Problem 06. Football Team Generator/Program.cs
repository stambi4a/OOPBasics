namespace Problem_06.Football_Team_Generator
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var teams = new Dictionary<string, Team>();
            while (true)
            {
                try
                {
                    var line = Console.ReadLine();
                    if (line == "END")
                    {
                        break;
                    }

                    var input = line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (input[0] == "Team")
                    {
                        var teamName = input[1];
                        if (!teams.ContainsKey(teamName))
                        {
                            teams.Add(teamName, new Team(teamName));
                        }
                    }

                    if (input[0] == "Rating")
                    {
                        var team = input[1];
                        if (!teams.ContainsKey(team))
                        {
                            throw new InvalidOperationException($"Team {team} does not exist.");
                        }

                        Console.WriteLine($"{team} - {teams[team].Rating}");
                    }

                    if (input[0] == "Add")
                    {
                        var team = input[1];
                        if (!teams.ContainsKey(team))
                        {
                            throw new InvalidOperationException($"Team {team} does not exist.");
                        }

                        var playerName = input[2];
                        var endurance = int.Parse(input[3]);
                        var sprint = int.Parse(input[4]);
                        var dribble = int.Parse(input[5]);
                        var passing = int.Parse(input[6]);
                        var shooting = int.Parse(input[7]);

                        var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        teams[team].AddPlayer(playerName, player);
                    }

                    if (input[0] == "Remove")
                    {
                        var team = input[1];
                        if (!teams.ContainsKey(team))
                        {
                            throw new InvalidOperationException($"Team {team} does not exist.");
                        }

                        var playerName = input[2];
                        teams[team].RemovePlayer(playerName);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
        }
    }
}
