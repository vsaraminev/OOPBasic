using System;
using System.Collections.Generic;
using System.Linq;

public class RawData
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            var model = input[0];
            var engineSpeed = int.Parse(input[1]);
            var enginePower = int.Parse(input[2]);
            var engine = new Engine(engineSpeed, enginePower);

            var cargoWeight = int.Parse(input[3]);
            var cargoType = input[4];
            var cargo = new Cargo(cargoWeight, cargoType);

            var tires = new Tire[4];

            var t1Pres = double.Parse(input[5]);
            var t1 = int.Parse(input[6]);
            var tire1 = new Tire(t1, t1Pres);
            tires[0] = tire1;

            var t2Pres = double.Parse(input[7]);
            var t2 = int.Parse(input[8]);
            var tire2 = new Tire(t2, t2Pres);
            tires[1] = tire2;

            var t3Pres = double.Parse(input[9]);
            var t3 = int.Parse(input[10]);
            var tire3 = new Tire(t3, t3Pres);
            tires[2] = tire3;

            var t4Pres = double.Parse(input[11]);
            var t4 = int.Parse(input[12]);
            var tire4 = new Tire(t4, t4Pres);
            tires[3] = tire4;

            var car = new Car(model, engine, cargo, tires);

            cars.Add(car);
        }
        
        var command = Console.ReadLine();

        var resultCars = new List<Car>();

        if (command == "fragile")
        {
            resultCars = cars
                .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(p => p.Pressure < 1))
                .ToList();            
        }
        else
        {
            resultCars = cars
                .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                .ToList();
        }

        foreach (var car in resultCars)
        {
            Console.WriteLine($"{car.Model}");
        }
    }
}

