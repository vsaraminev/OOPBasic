using System.Collections.Generic;
using System;
using System.Linq;

public class Player
{
    private string name;
    private Stat stats;

    public Player(string name, Stat stats)
    {
        this.Name = name;
        this.Stats = stats;
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

    public Stat Stats
    {
        get { return stats; }
        private set { stats = value; }
    }

    public double SkillLevel => GetSkillLevel();

    private double GetSkillLevel()
    {
        var stats = new List<double>()
        {
            this.stats.Endurance,
            this.stats.Dribble,
            this.stats.Sprint,
            this.stats.Shooting,
            this.stats.Passing,
        };

        return stats.Average();
    }
}

