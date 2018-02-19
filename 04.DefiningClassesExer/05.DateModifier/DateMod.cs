using System;

public class DateMod
{
    public static void Main()
    {
        string startDate = Console.ReadLine();
        string endDate = Console.ReadLine();

        DateModifier date = new DateModifier();

        var result = Math.Abs(date.DateDiff(startDate, endDate));

        Console.WriteLine(result);
    }
}

