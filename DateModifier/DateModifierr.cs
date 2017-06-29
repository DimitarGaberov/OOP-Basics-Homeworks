using System;

public class DateModifierr
{
    public void DaysDifference(string firstDate, string secondDate)
    {
        var date1 = DateTime.Parse(firstDate);
        var date2 = DateTime.Parse(secondDate);
        var output = Math.Abs((date1 - date2).TotalDays);
        Console.WriteLine(output);
    }
}

