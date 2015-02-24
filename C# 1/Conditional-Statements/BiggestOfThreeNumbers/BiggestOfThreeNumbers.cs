using System;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

// Write a program that finds the biggest of three numbers.

class BiggestOfThreeNumbers
{
    private static float a, b, c;

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
    }

    static void PrintBiggestNumber()
    {
        Console.WriteLine("Biggest Number is: " + BiggestNumber());
    }

    static float BiggestNumber()
    {
        if (a > b && a > c)
        {
            return a;
        }
        if(b > a && b > c)
        {
            return b;
        }
        if(c > a && c > b)
        {
            return c;
        }
        return 0;
    }
}