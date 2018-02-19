using System;
using System.Collections.Generic;
using System.Linq;

public class SpeedRacing
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            var model = input[0];
            var fuelAmount = decimal.Parse(input[1]);
            var fuelConsum = decimal.Parse(input[2]);

            var currentCar = new Car(model, fuelAmount, fuelConsum);
            
            cars.Add(currentCar);
        }
        
        var inputCommand = Console.ReadLine();

        while (inputCommand != "End" )
        {
            var command = inputCommand.Split();

            var model = command[1];
            var distance = int.Parse(command[2]);

            Car currentCar = cars.FirstOrDefault(c => c.Model == model);

            currentCar.CalculateDistance(distance);

            inputCommand = Console.ReadLine();
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
        }
    }
}
