using System;
using System.Collections.Generic;

public class ValidationOfData
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var persons = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split();
            try
            {
                var person = new Person(line[0], line[1], int.Parse(line[2]), decimal.Parse(line[3]));

                persons.Add(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        var bonus = decimal.Parse(Console.ReadLine());

        persons.ForEach(p => p.IncreaseSalary(bonus));

        foreach (var person in persons)
        {
            Console.WriteLine(person.ToString());
        }
    }
}

