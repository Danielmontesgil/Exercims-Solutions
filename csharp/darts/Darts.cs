using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        var distance = Math.Pow(x, 2) + Math.Pow(y, 2);

        return distance switch
        {
            > 100 => 0,
            > 25 => 1,
            > 1 => 5,
            _ => 10
        };
    }
}
