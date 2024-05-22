using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColor
{
    private static Dictionary<string, int> resistors = new Dictionary<string, int>
    {
        {"black", 0},
        {"brown", 1},
        {"red", 2},
        {"orange", 3},
        {"yellow", 4},
        {"green", 5},
        {"blue", 6},
        {"violet", 7},
        {"grey", 8},
        {"white", 9}
    };

    public static int ColorCode(string color) => resistors.TryGetValue(color.ToLower(), out var value) ? value : -1;

    public static string[] Colors() => resistors.Keys.ToArray();

    public static int ColorCodeOther(string color) => Array.IndexOf(ColorsOther(), color);

    private static string[] ColorsOther() => new[]
        { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
}