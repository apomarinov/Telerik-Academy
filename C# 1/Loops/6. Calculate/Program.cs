using System;

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

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
        Console.WriteLine("Result: " + Factorial(n) / Factorial(x));
    }

    static int Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}
