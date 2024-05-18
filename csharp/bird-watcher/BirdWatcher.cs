using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today() => birdsPerDay.Last();

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Any(birdsCount => birdsCount == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var sum = 0;
        if (numberOfDays > birdsPerDay.Length)
        {
            return -1;
        }

        for (var i = 0; i < numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        }

        return sum;
    }

    public int BusyDays()
    {
        return birdsPerDay.Count(birdsCount => birdsCount >= 5);
    }
}
