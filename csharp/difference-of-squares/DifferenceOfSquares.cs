using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var sum = 0;
        for (int i = 1; i <= max; i++)
        {
            sum += i;
        }

        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        var sum = 0;
        for (int i = 1; i <= max; i++)
        {
            sum += i * i;
        }
    
        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    
    // Other Solution
    // public static int CalculateSquareOfSum(int max) =>
    //     Square(Enumerable.Range(1, max).Sum());
    //
    // public static int CalculateSumOfSquares(int max) =>
    //     Enumerable.Range(1, max).Sum(Square);
    //
    // public static int CalculateDifferenceOfSquares(int max) =>
    //     CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    //
    // private static int Square(int number) => number * number;
}