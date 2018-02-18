using System;
using System.Linq;

public class PointInRectangle
{
    public static void Main()
    {
        var coordinates = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        
        var rectangle = new Rectangle(coordinates[0], coordinates[1], coordinates[2], coordinates[3]);

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var currerntPoint = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var point = new Point(currerntPoint[0], currerntPoint[1]);

            Console.WriteLine(rectangle.Contains(point));
        }
    }
}

