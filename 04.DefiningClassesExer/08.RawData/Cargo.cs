﻿public class Cargo
{
    private int weight;
    private string type;

    public Cargo(int weight,string type)
    {
        this.Weiht = weight;
        this.Type = type;
    }

    public int Weiht
    {
        get { return weight; }
        set { weight = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

}

