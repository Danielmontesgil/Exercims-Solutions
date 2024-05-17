using System;

public static class Gigasecond
{
    private static int _gigaSecond = 1000000000;
    public static DateTime Add(DateTime moment) => moment.AddSeconds(_gigaSecond);
}