using System;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

// Write a program that finds the biggest of five numbers by using only five if statements.

class BiggestOfFiveNumbers
{
    private static float a, b, c, d, e;

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        ReadNumbers();
        PrintBiggestNumber();
    }

    static void ReadNumbers()
    {
        Console.Write("Enter a: ");
        float.TryParse(Console.ReadLine(), out a);

        Console.Write("Enter b: ");
        float.TryParse(Console.ReadLine(), out b);

        Console.Write("Enter c: ");
        float.TryParse(Console.ReadLine(), out c);

        Console.Write("Enter d: ");
        float.TryParse(Console.ReadLine(), out d);

        Console.Write("Enter e: ");
        float.TryParse(Console.ReadLine(), out e);
    }

    static void PrintBiggestNumber()
    {
        Console.WriteLine("Biggest Number is: " + BiggestNumber());
    }

    static float BiggestNumber()
    {
        if (a > b && a > c && a > d && a > e)
        {
            return a;
        }
        if (b > a && b > c && b > d && b > e)
        {
            return b;
        }
        if (c > a && c > b && c > d && c > e)
        {
            return c;
        }
        if(d > a && d > b && d > c && d > e)
        {
            return d;
        }
        if(e > a && e > b && e > c && e > d)
        {
            return e;
        }
        return 0;
    }
}