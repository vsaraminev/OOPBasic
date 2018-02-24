using System;
using System.Collections.Generic;
using System.Linq;

public class FootballTeamGenerator
{
    public static void Main()
    {
        var teams = new List<Team>();

        var input = Console.ReadLine();

        while (input != "END")
        {
            var tokens = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var command = tokens[0];

                if (command == "Team")
                {
                    var teamName = tokens[1];
                    var team = new Team(teamName);
                    teams.Add(team);
                }
                else if (command == "Add")
                {
                    var teamToAdd = tokens[1];
                    if (!teams.Any(t => t.Name == teamToAdd))
                    {
                        throw new ArgumentException($"Team {teamToAdd} does not exist.");
                    }
                    var stats = new Stat(double.Parse(tokens[3]), double.Parse(tokens[4]), double.Parse(tokens[5]), double.Parse(tokens[6]), double.Parse(tokens[7]));

                    var player = new Player(tokens[2], stats);

                    teams.FirstOrDefault(t => t.Name == teamToAdd).AddPlayer(player);
                }
                else if (command == "Remove")
                {
                    var teamName = tokens[1];
                    var playerToRemove = tokens[2];

                    teams.FirstOrDefault(t => t.Name == teamName).RemovePlayer(playerToRemove);
                }
                else if (command == "Rating")
                {
                    var teamToRating = tokens[1];

                    if (teams.All(t => t.Name != teamToRating))
                    {
                        throw new ArgumentException($"Team {teamToRating} does not exist.");
                    }

                    Console.WriteLine($"{teams.FirstOrDefault(t => t.Name == teamToRating)}");
                }
                
                input = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                input = Console.ReadLine();
            }
        }
    }
}

