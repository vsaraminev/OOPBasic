using System;

public class Topping
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 50;
    private const int DEFAULT_CAL = 2;

    private string toppingType;
    private decimal weight;

    private decimal[] toppingMod = new decimal[] { 1.2m, 0.8m, 1.1m, 0.9m };

    public Topping(string toppingType, decimal weight)
    {
        this.ToppingType = toppingType;
        this.Weight = weight;
    }

    public string ToppingType
    {
        get { return toppingType; }
        private set
        {
            if (!Enum.IsDefined(typeof(ToppingType), value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            toppingType = value;
        }
    }

    public decimal Weight
    {
        get { return weight; }
        private set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException($"{this.ToppingType} weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
            }
            weight = value;
        }
    }

    public decimal CalculateCalories()
    {
        var toppingCal = toppingMod[(int)Enum.Parse(typeof(ToppingType), this.ToppingType.ToLower())];

        return DEFAULT_CAL * this.Weight * toppingCal;
    }

    public override string ToString()
    {
        return $"{CalculateCalories():f2}";
    }
}

