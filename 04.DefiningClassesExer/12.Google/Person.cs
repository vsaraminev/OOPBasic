using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private Company company;
    private List<Pokemon> pokemons;
    private List<Parents> parents;
    private List<Children> childrens;
    private Car car;

    public Person(string name)
    {
        this.Name = name;
        this.Company = company;
        this.Pokemons = new List<Pokemon>();
        this.Parents = new List<Parents>();
        this.Childrens = new List<Children>();
        this.Car = car;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Company Company
    {
        get { return company; }
        set { company = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public List<Parents> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public List<Children> Childrens
    {
        get { return childrens; }
        set { childrens = value; }
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"{this.Name}");

        result.AppendLine($"Company:");
        if (this.Company != null)
        {
            result.AppendLine(this.Company.ToString());
        }

        result.AppendLine("Car:");
        if (this.Car != null)
        {
            result.AppendLine(this.Car.ToString());
        }
        result.AppendLine("Pokemon:");
        if (this.Pokemons != null)
        {
            foreach (var pokemon in Pokemons)
            {
                result.AppendLine(pokemon.ToString());
            }
        }

        result.AppendLine("Parents:");
        if (this.Parents != null)
        {
            foreach (var parent in Parents)
            {
                result.AppendLine(parent.ToString());
            }
        }

        result.AppendLine("Children:");
        if (this.Childrens != null)
        {
            foreach (var children in Childrens)
            {
                result.AppendLine(children.ToString());
            }
        }

        return result.ToString();
    }
}
