using System;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

class NumbersNotDivisibleBy3And7
{
    private static int n;

    static void Main()
    {
        Console.Write("Enter n: ");
        int.TryParse(Console.ReadLine(), out n);

        PrintNumbersToN();
    }

    static void PrintNumbersToN()
    {
        for (int i = 1; i <= n; i++)
        {
            if(i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
