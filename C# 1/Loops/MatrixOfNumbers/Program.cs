using System;

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

class Program
{
    static int n;

    static void Main()
    {
        ReadInput();
        if (InputIsNotValid())
        {
            Console.WriteLine("Invalid input");
            return;
        }
        PrintMatrix();
    }

    static void ReadInput()
    {
        Console.Write("Enter n: ");
        int.TryParse(Console.ReadLine(), out n);
    }

    static bool InputIsNotValid()
    {
        if (n < 1 || n > 20)
        {
            return true;
        }
        return false;
    }

    static void PrintMatrix()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(j + i + 1 + " ");
            }
            Console.WriteLine();
        }
    }
}
