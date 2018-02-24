using System;

public class Product
{
    private string name;
    private decimal price;

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public string Name
    {
        get
        {
            return name;
        }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(Name)} cannot be empty");
            }
            name = value;
        }
    }

    public decimal Price
    {
        get
        {
            return price;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(Price)} cannot be negative");
            }
            price = value;
        }
    }
}

