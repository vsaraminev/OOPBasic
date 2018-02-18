using System;

public class RhombusOfStars
{
    public static void Main()
    {
        var rhombusSize = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rhombusSize; i++)
        {
            PrintRow(rhombusSize, i);
        }

        for (int i = rhombusSize - 1; i > 0; i--)
        {
            PrintRow(rhombusSize, i);
        }
    }

    public static void PrintRow(int rhombusSize, int rowSize)
    {
        for (int i = 0; i < rhombusSize - rowSize; i++)
        {
            Console.Write(" ");
        }

        for (int i = 0; i < rowSize; i++)
        {
            Console.Write("* ");
        }

        Console.WriteLine();
    }
}
