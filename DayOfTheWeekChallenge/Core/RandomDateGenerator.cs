using System;

public static class RandomDateGenerator
{
    public static DateTime Generate(int pStartYear, int pEndYear)
    {
        var r = new Random();
        var start = new DateTime(pStartYear, 1, 1);
        var end = new DateTime(pEndYear, 12, 31);
        int range = (end - start).Days;

        var randomDate = start.AddDays(r.Next(range));

        return randomDate;
    }
}