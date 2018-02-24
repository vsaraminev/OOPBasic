using System;
using System.Collections.Generic;
using System.Linq;

public class ShoppingSpree
{
    public static void Main()
    {
        var persons = new List<Person>();
        var products = new List<Product>();
        try
        {

            var personsInput = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var pers in personsInput)
            {
                var arguments = pers.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                var name = arguments[0];
                var money = decimal.Parse(arguments[1]);

                var person = new Person(name, money);

                persons.Add(person);
            }

            var productsInput = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var prod in productsInput)
            {
                var arguments = prod.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                var name = arguments[0];

                var price = decimal.Parse(arguments[1]);

                var product = new Product(name, price);

                products.Add(product);
            }



            var command = Console.ReadLine();

            while (command != "END")
            {
                var arguments = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var personName = arguments[0];
                var productName = arguments[1];

                var person = persons.FirstOrDefault(p => p.Name == personName);

                var product = products.FirstOrDefault(p => p.Name == productName);

                if (person.CheckPersonMoney(product.Price))
                {
                    person.AddProduct(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }

                command = Console.ReadLine();
            }


            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }


        //foreach (var person in persons)
        //{
        //    Console.WriteLine(person.ToString());
        //}
    }
}

