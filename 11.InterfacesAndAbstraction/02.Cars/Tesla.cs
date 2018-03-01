using System;

public class Tesla : IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }
    public int Battery { get; }

    public string Model { get; }

    public string Color { get; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        return $"{this.Color} {GetType().Name} {this.Model} with {this.Battery} Batteries{Environment.NewLine}" +
            $"{Start()}{Environment.NewLine}" +
            $"{Stop()}";
    }
}
