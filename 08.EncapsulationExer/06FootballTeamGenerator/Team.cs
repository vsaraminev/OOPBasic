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
        this.Players = new List<Player>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }

    public List<Player> Players
    {
        get { return players; }
        set { players = value; }
    }

    public double Rating => GetRating(this.Players);

    private double GetRating(List<Player> players)
    {
        double result = 0.0;

        foreach (var player in this.Players)
        {
            result += player.SkillLevel;
        }

        return result;
    }

    public void AddPlayer(Player player)
    {
        this.Players.Add(player);
    }

    public void RemovePlayer(string player)
    {
        if (this.Players.All(p => p.Name != player))
        {
            throw new ArgumentException($"Player {player} is not in {this.Name} team.");
        }
        this.Players.RemoveAll(p => p.Name == player);
    }

    public override string ToString()
    {
        return $"{this.Name} - {Math.Round(this.Rating)}";
    }    
}

