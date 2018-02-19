using System;

public class DateModifier
{
    public double DateDiff(string firstDate, string endDate)
    {
        var first = DateTime.Parse(firstDate);
        var end = DateTime.Parse(endDate);

        double diff = (first - end).TotalDays;

        return diff;
    }
}

