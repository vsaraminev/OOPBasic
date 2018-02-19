using System;
using System.Collections.Generic;
using System.Linq;

public class OpinionPoll
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(' ');

            var name = line[0];

            var age = int.Parse(line[1]);

            var person = new Person();

            person.Name = name;
            person.Age = age;

            people.Add(person);
        }

        foreach (var person in people.Where(p => p.Age > 30).OrderBy(p => p.Name))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}

