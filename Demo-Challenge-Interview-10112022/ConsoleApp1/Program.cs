using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
/// <summary>
/// For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
/// </summary>
class Solution
{
    public static int solution(int[] A)
    {
        bool negative = A.Any(n => n < 0);
        if (negative) { return 1; }
        var ord = A.OrderBy(x => x).Distinct().ToArray();
        int len = ord.Length + 1;
        int formula = (len) * (len + 1) / 2;
        int sumaTot = ord.Sum();
        int ret = formula - sumaTot;


        return ret;
    }
}
