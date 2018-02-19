using System;
using System.Collections.Generic;
using System.Linq;

public class Google
{
    public static void Main()
    {
        var input = Console.ReadLine();

        var people = new List<Person>();

        while (input != "End")
        {
            var currentLine = input.Split();

            var name = currentLine[0];

            var person = people.FirstOrDefault(p => p.Name == name);

            if (person == null)
            {
                person = new Person(name);
                people.Add(person);
            }

            switch (currentLine[1])
            {
                case "company":
                    var companyName = currentLine[2];
                    var department = currentLine[3];
                    var salary = decimal.Parse(currentLine[4]);

                    var company = new Company(companyName, department, salary);
                    person.Company = company;
                    break;
                case "pokemon":
                    var pokemonName = currentLine[2];
                    var pokemonType = currentLine[3];

                    var pokemon = new Pokemon(pokemonName, pokemonType);
                    person.Pokemons.Add(pokemon);
                    break;
                case "parents":
                    var parentName = currentLine[2];
                    var parentBirthday = currentLine[3];

                    var parents = new Parents(parentName, parentBirthday);
                    person.Parents.Add(parents);
                    break;
                case "children":
                    var childrenName = currentLine[2];
                    var childrenBirthday = currentLine[3];

                    var children = new Children(childrenName, childrenBirthday);
                    person.Childrens.Add(children);
                    break;
                case "car":
                    var carModel = currentLine[2];
                    var carSpeed = currentLine[3];

                    var car = new Car(carModel, carSpeed);
                    person.Car = car;
                    break;
            }

            input = Console.ReadLine();
        }

        var command = Console.ReadLine();

        var personInfo = people.FirstOrDefault(p => p.Name == command);
        
        Console.WriteLine(personInfo.ToString());
    }
}

