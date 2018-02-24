using System;

public class Dough
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 200;
    private const int DEFAULT_DOUGH_CAL = 2;

    private string flourType;
    private string bakingTechnique;
    private decimal weight;

    private decimal[] flourMod = new decimal[] { 1.5m, 1.0m };
    private decimal[] bakingMod = new decimal[] { 0.9m, 1.1m, 1.0m };

    public Dough(string flourType, string bakingTechnique, decimal weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        get { return flourType; }
        private set
        {
            if (!Enum.IsDefined(typeof(FlourType), value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        private set
        {
            if (!Enum.IsDefined(typeof(BakingTechnique), value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value;
        }
    }

    public decimal Weight
    {
        get { return weight; }
        private set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
            }
            weight = value;
        }
    }

    private decimal CalculateCalories()
    {
        var flourCal = flourMod[(int)Enum.Parse(typeof(FlourType), this.FlourType.ToLower())];
        var bakingCal = bakingMod[(int)Enum.Parse(typeof(BakingTechnique), this.BakingTechnique.ToLower())];

        return DEFAULT_DOUGH_CAL * this.Weight * flourCal * bakingCal;
    }

    public override string ToString()
    {
        return $"{CalculateCalories():f2}";
    }
}

