using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

[MemoryDiagnoser]
public class BenchMe
{
    [Params("", "robot", "I'm hungry!", "racecar")]
    public string input = "";
    
    [Benchmark]
    public string ReverseLinQ() => new (input.Reverse().ToArray());

    [Benchmark]
    public string Reverse()
    {
        StringBuilder builder = new StringBuilder();
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            builder.Append(input[i]);
        }

        return builder.ToString();
    }

    [Benchmark]
    public string ReverseCharArray()
    {
        char[] a = input.ToCharArray();
        Array.Reverse(a);
        return new string(a);
    }
}
static class Program
{
    public static void Main()
    {
        var summary = BenchmarkRunner.Run<BenchMe>();
    }
}