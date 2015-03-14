using System;

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

class Program
{
    static int n, x;

    static void Main()
    {
        ReadInput();
        PrintResult();
    }

    static void ReadInput()
    {
        Console.Write("Enter n: ");
        int.TryParse(Console.ReadLine(), out n);
        Console.Write("Enter x: ");
        int.TryParse(Console.ReadLine(), out x);
    }

    static void PrintResult()
    {
        Console.WriteLine("Result: " + Result());
    }

    static string Result()
    {
        float sum = 1;

        for (int i = 0; i < n; i++)
        {
            sum += Part(i + 1);
        }

        return sum.ToString("F5");
    }

    static float Part(int i)
    {
        return Factorial(i) / (float)(Math.Pow(x, i));
    }

    static int Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}