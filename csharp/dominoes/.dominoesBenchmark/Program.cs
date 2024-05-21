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
    public IEnumerable<(int, int)[]> Dominoes() // for multiple arguments it's an IEnumerable of array of objects (object[])
    {
        yield return new[] { (1, 2), (5, 3), (3, 1), (1, 2), (2, 4), (1, 6), (2, 3), (3, 4), (5, 6) };
        yield return new[] { (1, 2), (2, 3), (3, 1), (4, 5), (5, 6), (6, 4) };
        yield return new[] { (1, 2), (2, 3), (3, 1), (2, 4), (2, 4) };
        yield return new[] { (1, 1), (2, 2) };
    }
    
    [Benchmark]
    [ArgumentsSource(nameof(Dominoes))]
    public bool CanChain(IEnumerable<(int, int)> dominoes) => TryToChain(dominoes.ToList(), (-1, -1));

    private bool TryToChain(List<(int a, int b)> dominoes, (int first, int last) state)
    {
        if (dominoes.Count == 0 && state.first == state.last)
        {
            return true;
        }
        
        foreach(var domino in dominoes)
        {
            if (state.first == -1 || state.last == -1)
            {
                state = domino;
            }
            else if (state.last == domino.a)
            {
                state.last = domino.b;
            }
            else if (state.last == domino.b)
            {
                state.last = domino.a;
            }
            else
            {
                continue;
            }

            var list = new List<(int a, int b)>(dominoes);
            list.Remove(domino);
            if (TryToChain(list, state))
            {
                return true;
            }
        }

        return false;
    }

    [Benchmark]
    [ArgumentsSource(nameof(Dominoes))]
    public bool MyApproach(IEnumerable<(int, int)> dominoes)
    {
        var tempList = dominoes.ToList();
        var possibleMatches = new List<(int, int)>();
        
        switch (tempList.Count)
        {
            case < 1:
                return true;
            case 1:
                return tempList[0].Item1 == tempList[0].Item2;
        }

        var stoneToCheck = tempList[0];
        tempList.Remove(stoneToCheck);

        foreach (var nextStone in tempList)
        {
            if (stoneToCheck.Item2 != nextStone.Item1 && stoneToCheck.Item2 != nextStone.Item2)
            {
                continue;
            }

            possibleMatches.Add(nextStone);
        }

        foreach (var possibleMatch in possibleMatches)
        {
            (int, int) newStone;
            if (stoneToCheck.Item2 == possibleMatch.Item1)
            {
                newStone = (stoneToCheck.Item1, possibleMatch.Item2);
            }
            else if (stoneToCheck.Item2 == possibleMatch.Item2)
            {
                newStone = (stoneToCheck.Item1, possibleMatch.Item1);
            }
            else
            {
                continue;
            }
            
            tempList.Remove(possibleMatch);
            tempList.Add(newStone);
            if (MyApproach(tempList))
            {
                return true;
            }
            
            tempList.Add(possibleMatch);
            tempList.Remove(newStone);
        }

        return false;
    }
}
static class Program
{
    public static void Main()
    {
        var summary = BenchmarkRunner.Run<BenchMe>();
    }
}