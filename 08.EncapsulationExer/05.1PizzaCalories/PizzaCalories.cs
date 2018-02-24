using System;

public class PizzaCalories
{
    public static void Main()
    {
        try
        {
            var pizzaInput = Console.ReadLine().Split();

            var pizzaName = pizzaInput[1];

            var dough = CreateDough();

            var pizza = new Pizza(pizzaName, dough);

            var command = Console.ReadLine();

            while (command != "END")
            {
                CreateTopping(command, pizza);

                command = Console.ReadLine();
            }

            Console.WriteLine(pizza);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }        
    }

    private static Dough CreateDough()
    {
        var doughInput = Console.ReadLine().Split();

        var flourType = doughInput[1];

        var bakingTech = doughInput[2];

        var doughWeight = double.Parse(doughInput[3]);

        var dough = new Dough(flourType, bakingTech, doughWeight);

        return dough;
    }

    public static void CreateTopping(string command, Pizza pizza)
    {
        var toppingInput = command.Split();

        var toppingName = toppingInput[1];

        var toppingWeight = double.Parse(toppingInput[2]);

        var topping = new Topping(toppingName, toppingWeight);

        pizza.AddTopping(topping);
    }
}

