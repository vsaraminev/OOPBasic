using System;

public class Program
{
    public static Pizza pizza;

    public static void Main()
    {      

        try
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split();

                var item = tokens[0];

                if (item == "Pizza")
                {
                    var pizzaName = tokens[1];

                    pizza = new Pizza(pizzaName);
                }
                else if (item == "Dough")
                {
                    var flourType = tokens[1];
                    var bakingTech = tokens[2];
                    var weight = decimal.Parse(tokens[3]);

                    var dough = new Dough(flourType, bakingTech, weight);

                    pizza.Dough = dough;
                }
                else if (item == "Topping")
                {
                    var toppingType = tokens[1];
                    var weight = decimal.Parse(tokens[2]);

                    var topping = new Topping(toppingType, weight);

                    pizza.AddTopping(topping);
                }

                input = Console.ReadLine();
            }

            if (pizza != null)
            {
                Console.WriteLine(pizza);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

