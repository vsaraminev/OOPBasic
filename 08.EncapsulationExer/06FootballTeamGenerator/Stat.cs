using System;

public class Stat
{
    private const int MIN_STAT = 0;
    private const int MAX_STAT = 100;

    private double endurance;
    private double sprint;
    private double dribble;
    private double passing;
    private double shooting;

    public Stat(double endurance, double sprint, double dribble,double passing, double shooting)
    {
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Shooting = shooting;
        this.Passing = passing;
    }

    public double Endurance
    {
        get { return endurance; }
        private set
        {
            ValidateStat(nameof(this.Endurance), value);
            endurance = value;
        }
    }

    public double Sprint
    {
        get { return sprint; }
        private set
        {
            ValidateStat(nameof(this.Sprint), value);
            sprint = value;
        }
    }


    public double Dribble
    {
        get { return dribble; }
        private set
        {
            ValidateStat(nameof(this.Dribble), value);
            dribble = value;
        }
    }


    public double Passing
    {
        get { return passing; }
        private set
        {
            ValidateStat(nameof(this.Passing), value);
            passing = value;
        }
    }

    public double Shooting
    {
        get { return shooting; }
        private set
        {
            ValidateStat(nameof(this.Shooting), value);
            shooting = value;
        }
    }

    private void ValidateStat(string stat, double value)
    {
        if (value < MIN_STAT || value > MAX_STAT)
        {
            throw new ArgumentException($"{stat} should be between {MIN_STAT} and {MAX_STAT}.");
        }
    }

}

