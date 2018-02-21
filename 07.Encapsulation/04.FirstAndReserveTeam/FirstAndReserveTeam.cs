using System;
using System.Collections.Generic;

public class FirstAndReserveTeam
{
    public static void Main()
    {
        var team = new Team("SoftUni");
        
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split();

            try
            {
                var person = new Person(line[0], line[1], int.Parse(line[2]), decimal.Parse(line[3]));

                team.AddPlayer(person);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        Console.WriteLine(team.ToString());
    }
}

