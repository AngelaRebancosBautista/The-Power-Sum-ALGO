using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'powerSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER X
     *  2. INTEGER N
     */

    public static int powerSum(int X, int N)
    {
         return CountWays(X, N, 1);
    }

    private static int CountWays(int target, int power, int start)
    {
        if (target == 0) return 1;   
        if (target < 0) return 0;   

        int ways = 0;

        for (int i = start; Math.Pow(i, power) <= target; i++)
        {
            ways += CountWays(target - (int)Math.Pow(i, power), power, i + 1);
        }

        return ways;
    }
}


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int X = Convert.ToInt32(Console.ReadLine().Trim());

        int N = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.powerSum(X, N);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
