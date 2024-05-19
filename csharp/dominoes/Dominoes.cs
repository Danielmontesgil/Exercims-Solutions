using System;
using System.Collections.Generic;
using System.Linq;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes) => TryToChain(dominoes.ToList(), (-1, -1));

    private static bool TryToChain(List<(int a, int b)> dominoes, (int first, int last) state)
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

    public static bool MyApproach(IEnumerable<(int, int)> dominoes)
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
            if (CanChain(tempList))
            {
                return true;
            }
            
            tempList.Add(possibleMatch);
            tempList.Remove(newStone);
        }

        return false;
    }
}