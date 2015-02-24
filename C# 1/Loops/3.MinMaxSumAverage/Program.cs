using System;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below

class Program
{
    private static int n;
    private static int[] numbers;

    static void Main()
    {
        ReadN();
        ReadNumbers();
        PrintOutput();
    }

    static void ReadN()
    {
        Console.Write("Enter n: ");
        int.TryParse(Console.ReadLine(), out n);
        numbers = new int[n];
    }

    static void ReadNumbers()
    {
        Console.WriteLine("Enter numbers:");
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out numbers[i]);
        }
    }

    static void PrintOutput()
    {
        Console.WriteLine("Min: " + Min());
        Console.WriteLine("Max: " + Max());
        Console.WriteLine("Sum: " + Sum());
        Console.WriteLine("Average: " + Average());
    }

    static int Min()
    {
        int min = numbers[0];

        for (int i = 0; i < n; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }

        return min;
    }

    static int Max()
    {
        int max = numbers[0];

        for (int i = 0; i < n; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }

        return max;
    }

    static int Sum()
    {
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    static int Average()
    {
        return Sum() / n;
    }
}
