using System.Collections.Generic;
using System;
using System.Linq;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.Products = new List<Product>();
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

    public decimal Money
    {
        get
        {
            return money;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(Money)} cannot be negative");
            }
            money = value;
        }
    }

    public List<Product> Products
    {
        get { return products; }
        private set { products = value; }
    }

    public bool CheckPersonMoney(decimal price)
    {
        return this.Money - price >= 0;
    }

    public void AddProduct(Product product)
    {
        this.Products.Add(product);
        this.Money -= product.Price;
    }

    public override string ToString()
    {
        if (this.Products.Any())
        {
            return $"{this.Name} - {string.Join(", ", this.Products.Select(p => p.Name))}";
        }
        else
        {
            return $"{this.Name} - Nothing bought";
        }
    }
}

