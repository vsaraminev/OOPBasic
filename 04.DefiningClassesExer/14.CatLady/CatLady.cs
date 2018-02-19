using System;
using System.Collections.Generic;
using System.Linq;

public class CatLady
{
    static void Main()
    {
        var input = Console.ReadLine();

        var cats = new List<Cat>();

        while (input != "End")
        {
            var currentInput = input.Split();

            if (currentInput[0] == "Siamese")
            {
                var siamese = new Siamese(currentInput[0], currentInput[1], int.Parse(currentInput[2]));

                cats.Add(siamese);
            }
            else if (currentInput[0] == "Cymric")
            {
                var cymric = new Cymric(currentInput[0], currentInput[1], double.Parse(currentInput[2]));
                cats.Add(cymric);
            }
            else if (currentInput[0] == "StreetExtraordinaire")
            {
                var StreetExtraordinaire = new StreetExtraordinaire(currentInput[0], currentInput[1], int.Parse(currentInput[2]));
                cats.Add(StreetExtraordinaire);
            }

            input = Console.ReadLine();
        }

        var catName = Console.ReadLine();

        var result = cats.FirstOrDefault(c => c.Name == catName);

        Console.WriteLine(result.ToString());
    }
}
