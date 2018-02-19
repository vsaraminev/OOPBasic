using System;

public class Car
{
    private string model;
    private decimal fuelAmount;
    private decimal fuelConsumption;
    private int distance;

    public Car(string model, decimal fuelAmount, decimal fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.Distance = 0;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public decimal FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }

    public decimal FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    public int Distance
    {
        get { return distance; }
        set { distance = value; }
    }

    public void CalculateDistance(int distance)
    {
        if (distance * this.FuelConsumption <= this.FuelAmount)
        {
            this.FuelAmount -=distance * this.FuelConsumption;
            this.Distance += distance;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}

