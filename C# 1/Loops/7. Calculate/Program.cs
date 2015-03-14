using System;
using System.Numerics;

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula:
//formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

class Program
{
    static int n, x;

    static void Main()
    {
        ReadInput();
        if (InputIsNotValid())
        {
            Console.WriteLine("One of the numbers are less than 1 or greater than 100");
            return;
        }
        PrintResult();
    }

    static void ReadInput()
    {
        Console.Write("Enter n: ");
        int.TryParse(Console.ReadLine(), out n);
        Console.Write("Enter x: ");
        int.TryParse(Console.ReadLine(), out x);
    }

    static bool InputIsNotValid()
    {
        if (n < 1 || n > 100 || x < 1 || x > 100)
        {
            return true;
        }
        return false;
    }

    static void PrintResult()
    {
        Console.WriteLine("Result: " + Factorial(n) / (Factorial(x) * Factorial(n - x)));
    }

    static BigInteger Factorial(BigInteger n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}
