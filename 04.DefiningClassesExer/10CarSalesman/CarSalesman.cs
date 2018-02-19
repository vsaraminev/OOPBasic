using System;
using System.Collections.Generic;
using System.Linq;

public class CarSalesman
{
    public static void Main()
    {
        int enginesCount = int.Parse(Console.ReadLine());

        var engines = new List<Engine>();

        for (int i = 0; i < enginesCount; i++)
        {
            var input = Console.ReadLine().Split(new[] {' ' },StringSplitOptions.RemoveEmptyEntries);

            var model = input[0];
            var power = int.Parse(input[1]);

            var engine = new Engine(model, power);

            if (input.Length == 3)
            {
                int displacement;

                if (int.TryParse(input[2], out displacement))
                {
                    engine.Displacement = input[2];
                }
                else
                {
                    engine.Efficiency = input[2];
                }
            }

            if (input.Length == 4)
            {
                engine.Displacement = input[2];
                engine.Efficiency = input[3];
            }

            engines.Add(engine);
        }

        int carsCount = int.Parse(Console.ReadLine());

        var cars = new List<Car>();

        for (int i = 0; i < carsCount; i++)
        {
            var input = Console.ReadLine().Split(new[] {' ' },StringSplitOptions.RemoveEmptyEntries);

            var model = input[0];
            var engine = input[1];

            var car = new Car(model, engines.FirstOrDefault(e => e.Model == engine));

            if (input.Length == 3)
            {
                int weight;

                if (int.TryParse(input[2], out weight))
                {
                    car.Weight = input[2];
                }
                else
                {
                    car.Color = input[2];
                }
            }

            if (input.Length == 4)
            {
                car.Weight = input[2];
                car.Color = input[3];
            }

            cars.Add(car);
        }

        foreach (var car in cars)
        {
            Console.Write(car.ToString());
        }
    }
}

