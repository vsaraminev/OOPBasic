using System;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private string weight = "n/a";
    private string color = "n/a";

    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = weight;
        this.Color = color;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public string Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine($"{this.Model}:");
        result.Append(this.Engine.ToString());
        result.AppendLine($"  Weight: {this.Weight}");
        result.AppendLine($"  Color: {this.Color}");

        return result.ToString();
    }
}

