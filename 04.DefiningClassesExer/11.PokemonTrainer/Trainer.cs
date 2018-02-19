using System.Collections.Generic;

public class Trainer
{
    private string name;
    private int badgesNum;
    private List<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.Name = name;
        this.BadgesNum = 0;
        this.Pokemons = new List<Pokemon>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int BadgesNum
    {
        get { return badgesNum; }
        set { badgesNum = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }
    public override string ToString()
    {
        return $"{this.Name} {this.BadgesNum} {this.Pokemons.Count}";
    }
}
