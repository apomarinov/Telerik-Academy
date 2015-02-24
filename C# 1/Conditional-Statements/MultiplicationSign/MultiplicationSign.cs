using System;

// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

class MultiplicationSign
{
    private static int a, b, c;

    static void Main()
    {
        ReadNumbers();
        PrintMultiplicationSign();
    }

    static void ReadNumbers()
    {
        Console.Write("Enter a: ");
        int.TryParse(Console.ReadLine(), out a);

        Console.Write("Enter b: ");
        int.TryParse(Console.ReadLine(), out b);

        Console.Write("Enter c: ");
        int.TryParse(Console.ReadLine(), out c);
    }

    static void PrintMultiplicationSign()
    {
        if (SignIsZero())
        {
            Console.WriteLine(0);
        } 
        else if (SignIsMinus())
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("+");
        }
    }

    static bool SignIsZero()
    {
        return (a == 0 || b == 0 || c == 0);
    }
    
    static bool SignIsMinus()
    {
        return (AllAreNegative() || OneIsNegative());
    }

    static bool AllAreNegative()
    {
        return (a < 0 && b < 0 && c < 0);
    }

    static bool OneIsNegative()
    {
        return (a < 0 && b >= 0 && c >= 0 || a >= 0 && b < 0 && c >= 0 || a >= 0 && b >= 0 && c < 0);
    }
}
