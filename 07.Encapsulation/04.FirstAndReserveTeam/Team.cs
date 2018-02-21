using System.Collections.Generic;
using System;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public Team(string name)
    {
        this.Name = name;
        this.FirstTeam = new List<Person>();
        this.ReserveTeam = new List<Person>();
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public List<Person> FirstTeam
    {
        get { return firstTeam; }
        private set { firstTeam = value; }
    }

    public List<Person> ReserveTeam
    {
        get { return reserveTeam; }
        private set { reserveTeam = value; }
    }

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
        {
            FirstTeam.Add(person);
        }
        else
        {
            ReserveTeam.Add(person);
        }
    }

    public override string ToString()
    {
        return $"First team has {this.FirstTeam.Count} players.{Environment.NewLine}Reserve team has {this.ReserveTeam.Count} players.";
    }
}

