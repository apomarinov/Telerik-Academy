using System;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

// Write an if-statement that takes two double variables a and b and exchanges their values 
// if the first one is greater than the second one. As a result print the values a and b, separated by a space.

class ExchangeIfGreater
{
    private static double a, b, c;

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        ReadNumbers();
        SwapNumbers();
        PrintNumbers();
    }    
        
    static void ReadNumbers()
    {
        Console.Write("Enter a: ");
        double.TryParse(Console.ReadLine(), out a);

        Console.Write("Enter b: ");
        double.TryParse(Console.ReadLine(), out b);
    }

    static void SwapNumbers()
    {
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
    }

    static void PrintNumbers()
    {
        Console.WriteLine(a + " " + b);
    }
}