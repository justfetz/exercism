using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        //A gigasecond (symbol: Gs) is one billion seconds. That is about 31.7 years.
        return moment.AddSeconds(1000000000);
        //throw new NotImplementedException("You need to implement this function.");
    }
}