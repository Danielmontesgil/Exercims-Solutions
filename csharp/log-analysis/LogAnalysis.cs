using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter) => 
        str[(str.IndexOf(delimiter, StringComparison.Ordinal) + delimiter.Length)..];
    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter) =>
        str[(str.IndexOf(startDelimiter, StringComparison.Ordinal)+startDelimiter.Length)..str.IndexOf(endDelimiter, StringComparison.Ordinal)];
    public static string Message(this string str) => str[(str.IndexOf(':') + 1)..].Trim();
    public static string LogLevel(this string str) => str[1..str.IndexOf(']')];
}