using System.Collections.Generic;
using System;
using System.Linq;

public class Pizza
{
    private const int MIN_NAME_LENGTH = 1;
    private const int MAX_NAME_LENGTH = 15;
    private const int MIN_TOPPINGS = 0;
    private const int MAX_TOPPINGS = 10;

    private string name;
    private Dough dough;
    private List<Topping> toppings;

    public Pizza(string name, Dough dough)
    {
        this.Name = name;
        this.Dough = dough;
        this.Toppings = new List<Topping>();
    }

    private double ToppingsCalories
    {
        get
        {
            if (this.Toppings.Count == 0)
            {
                return 0;
            }

            return this.Toppings.Select(t => t.Calories).Sum();
        }
    }

    private double Calories => this.Dough.Calories + this.ToppingsCalories;

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value) || value.Length > MAX_NAME_LENGTH)
            {
                throw new ArgumentException($"Pizza name should be between {MIN_NAME_LENGTH} and {MAX_NAME_LENGTH} symbols.");
            }
            name = value;
        }
    }

    public Dough Dough
    {
        get { return dough; }
        private set { dough = value; }
    }

    public List<Topping> Toppings
    {
        get { return toppings; }
        private set
        {

            toppings = value;
        }
    }

    public void AddTopping(Topping topping)
    {
        this.Toppings.Add(topping);

        if (this.Toppings.Count > MAX_TOPPINGS)
        {
            throw new ArgumentException($"Number of toppings should be in range [{MIN_TOPPINGS}..{MAX_TOPPINGS}].");
        }
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Calories:f2} Calories.";
    }
}

