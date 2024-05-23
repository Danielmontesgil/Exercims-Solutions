using System;
using System.Text;

public static class ResistorColorDuo
{
    public static string[] resistorColors = new[]
        { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    
    public static int Value(string[] colors)
    {
        int value = 0;
        for(int i = 0; i < 2; i++)
        {
            value = 10 * value + Array.IndexOf(resistorColors, colors[i]);
        }

        return value;
    }
}
