using System;

public class OldestFamilyMember
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var family = new Family();

        for (int i = 0; i < n; i++)
        {
            var currentLine = Console.ReadLine().Split();

            var currentPerson = new Person();

            currentPerson.Name = currentLine[0];
            currentPerson.Age = int.Parse(currentLine[1]);

            family.AddMember(currentPerson);
        }

        var oldestMember = family.GetOldestMember();

        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");        
    }
}

