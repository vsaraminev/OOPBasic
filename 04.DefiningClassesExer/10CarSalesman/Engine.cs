using System.Text;

public class Engine
{
    private string model;
    private int power;
    private string displacement = "n/a";
    private string efficiency = "n/a";

    public Engine(string model, int power)
    {
        this.Model = model;
        this.Power = power;
        this.Displacement = displacement;
        this.Efficiency = efficiency;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    public string Displacement
    {
        get { return displacement; }
        set { displacement = value; }
    }

    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine($"  {this.Model}:");
        result.AppendLine($"    Power: {this.Power}");
        result.AppendLine($"    Displacement: {this.Displacement}");
        result.AppendLine($"    Efficiency: {this.Efficiency}");
        return result.ToString();
    }
}

