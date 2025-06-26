// find the nth Fibonacci number using recursion
using System;
class Program
{
    static int Fibonacci(int n)
    {
        if(n<=1)
            return n;
        return Fibonacci(n-1)+  Fibonacci(n-2);
    }
    public static void Main()
    {
        Console.WriteLine("Enter a number for Fibonacci series");
             int n= int.Parse(Console.ReadLine() );
        Console.WriteLine("Fibonacci number at position    " + n + "  is " + Fibonacci(n));
    }
}
//the memoized version (Dynamic Programming):
/*using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, int> memo = new Dictionary<int, int>();

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        if (memo.ContainsKey(n))
            return memo[n];

        memo[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
        return memo[n];
    }

    static void Main()
    {
        Console.WriteLine("Enter a number for Fibonacci series:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci number at position " + n + " is " + Fibonacci(n));
    }
}
*/