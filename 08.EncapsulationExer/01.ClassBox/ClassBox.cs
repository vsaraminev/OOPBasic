using System;

public class ClassBox
{
    public static void Main()
    {
        var length = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        var box = new Box(length, width, height);

        Console.WriteLine(box.ToString());
    }
}

