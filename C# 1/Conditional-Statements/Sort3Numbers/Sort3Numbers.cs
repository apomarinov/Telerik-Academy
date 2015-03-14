using System;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

class Sort3Numbers
{
    private static float a, b, c;

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        ReadNumbers();
        SortNumbers();
        PrintSortedNumbers();
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

    static void SortNumbers()
    {
        if(a > b && a > c)
        {
        	if(b < c || b == c)
        	{
        		SwapNumbers(b, c, out b, out c);
        	}
        }
        else if(b > a && b > c)
        {
        	if(a > c)
        	{
        		SwapNumbers(a, b, out a, out b);
        	}
        	else if(c > a || c == a)
        	{
        		SwapNumbers(a, b, out a, out b);
        		SwapNumbers(b, c, out b, out c);	
        	}
        }
        else if(c > a && c > b)
        {
        	if(a > b)
        	{
        		SwapNumbers(a, c, out a, out c);
        		SwapNumbers(b, c, out b, out c);
        	}
        	else if(b > c || b == a)
        	{
        		SwapNumbers(a, c, out a, out c);
        	}
        }
    }

    static void SwapNumbers(float num1, float num2, out float numOut1, out float numOut2)
    {
        numOut1 = num2;
        numOut2 = num1;
    }

    static void PrintSortedNumbers()
    {
        Console.WriteLine(a + " " + b + " " + c);
    }
}
