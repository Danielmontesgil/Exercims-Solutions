using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var test = new HashSet<int>();
    
        foreach (var number in multiples)
        {
            if (number == 0)
            {
                test.Add(0);
                continue;
            }
            var result = FindMultiples(number, max);
            test.UnionWith(result);
        }
    
        return test.ToList().Sum();
    }
    
    private static HashSet<int> FindMultiples(int number, int max)
    {
        var result = new HashSet<int>();
        for (int i = number; i < max; i += number)
        {
            result.Add(i);
        }
    
        return result;
    }

    private static int SimplierSolution(IEnumerable<int> multiples, int max)
    {
        // int result = 0;
        // for( int i = 1; i < max; i++ )
        // {
        // 	foreach( int m in multiples)
        // 	{
        // 		if( (i % m) == 0)
        // 		{
        // 			result += i;
        // 			break;
        // 		}	
        // 	}
        // }
        // return result;
        return Enumerable.Range(0, max).Where(x => multiples.Any(m => m != 0 && x % m == 0)).Sum();
    }
}