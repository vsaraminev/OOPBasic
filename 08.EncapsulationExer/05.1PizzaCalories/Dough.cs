using System.Collections.Generic;
using System.Linq;
using System;

public class Dough
{
    private Dictionary<string, double> validFlourTypes = new Dictionary<string, double>()
    {
        ["white"] = 1.5,
        ["wholegrain"] = 1.0
    };

    private Dictionary<string, double> validBakingTechniques = new Dictionary<string, double>()
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1.0
    };

    private const int MIN_WEIGHT = 1;
    private const int MAX_WEGHT = 200;
    private int DEFAULT_MULTIPLIER = 2;

    private string flourType;
    private string bakingTech;
    private double weight;

    public Dough(string flourType, string bakingTech, double weight)
    {
        this.FlourType = flourType;
        this.BakingTech = bakingTech;
        this.Weight = weight;
    }

    private double FlourMultiplier => validFlourTypes[this.FlourType];

    private double BakingTechMultiplier => validBakingTechniques[this.BakingTech];

    public double Calories => DEFAULT_MULTIPLIER * this.Weight * FlourMultiplier * BakingTechMultiplier;

    public string FlourType
    {
        get { return flourType; }
        set
        {
            if (!this.validFlourTypes.Any(t => t.Key == value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value.ToLower();
        }
    }

    public string BakingTech
    {
        get { return bakingTech; }
        set
        {
            if (!this.validBakingTechniques.Any(t => t.Key == value.ToLower()))
            {
                Console.WriteLine("Invalid type of dough.");
            }
            bakingTech = value.ToLower();
        }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < MIN_WEIGHT || value > MAX_WEGHT)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEGHT}].");
            }
            weight = value;
        }
    }
}
