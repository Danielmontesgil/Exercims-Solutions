using System;
using System.Linq;
using System.Text;

public static class ReverseString
{
    public static string ReverseLinQ(string input) => new (input.Reverse().ToArray());

    public static string Reverse(string input)
    {
        StringBuilder builder = new StringBuilder();
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            builder.Append(input[i]);
        }

        return builder.ToString();
    }

    public static string ReverseCharArray(string input)
    {
        char[] a = input.ToCharArray();
        Array.Reverse(a);
        return new string(a);
    }
    
    // Worth to study the Span type
}