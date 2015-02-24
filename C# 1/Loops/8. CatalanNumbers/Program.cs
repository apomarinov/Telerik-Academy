using System;
using System.Numerics;

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

class Program
{
    static int n;

    static void Main()
    {
        ReadInput();
        if (InputIsNotValid())
        {
            Console.WriteLine("N is less than 0 or greater than 100");
            return;
        }
        PrintResult();
    }

    static void ReadInput()
    {
        Console.Write("Enter n: ");
        int.TryParse(Console.ReadLine(), out n);
    }

    static bool InputIsNotValid()
    {
        if (n <= 0 || n > 100)
        {
            return true;
        }
        return false;
    }

    static void PrintResult()
    {
        Console.WriteLine("Result: " + Factorial(2*n) / (Factorial(n + 1) * Factorial(n)));
    }

    static BigInteger Factorial(BigInteger n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}
