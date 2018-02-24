using System.Collections.Generic;
using System;
using System.Linq;

public class Pizza
{
    private const int MIN_LENGTH = 1;
    private const int MAX_LENGTH = 15;
    private const int MIN_TOPPINGS = 0;
    private const int MAX_TOPPINGS = 10;

    private string name;
    private List<Topping> toppings;
    private Dough dough;

    public Pizza(string name)
    {
        this.Name = name;
        this.Dough = dough;
        this.Toppings = new List<Topping>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
            {
                throw new ArgumentException($"Pizza name should be between {MIN_LENGTH} and {MAX_LENGTH} symbols.");
            }
            name = value;
        }
    }

    public List<Topping> Toppings
    {
        get { return toppings; }
        private set
        {
            toppings = value;
        }
    }

    public Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }

    public decimal TotalCalories()
    {
        if (!this.Toppings.Any())
        {
            return 0;
        }
        return decimal.Parse(this.Dough.ToString()) + this.Toppings.Sum(t => decimal.Parse(t.ToString()));
    }

    public void AddTopping(Topping topping)
    {
        if (this.Toppings.Count >= MAX_TOPPINGS)
        {
            throw new ArgumentException($"Number of toppings should be in range [{MIN_TOPPINGS}..{MAX_TOPPINGS}].");
        }

        this.Toppings.Add(topping);
    }

    public override string ToString()
    {
        return $"{this.Name} - {TotalCalories():f2} Calories.";
    }
}

