using System;

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

class Program
{
    static int min, max;
    static int n;

    static void Main()
    {
        ReadInput();

        if (InputIsNotValid())
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        PrintRandomNumbers();
    }

    static void ReadInput()
    {
        Console.Write("Enter min: ");
        int.TryParse(Console.ReadLine(), out min);

        Console.Write("Enter max: ");
        int.TryParse(Console.ReadLine(), out max);

        Console.Write("Enter n: ");
        int.TryParse(Console.ReadLine(), out n);
    }

    static bool InputIsNotValid()
    {
        return min == max;
    }

    static void PrintRandomNumbers()
    {
        Console.WriteLine(FormatedRandomNumbers());
    }

    static string FormatedRandomNumbers()
    {
        return String.Join(" ", RandomNumbersInInterval(min, max));
    }

    static int[] RandomNumbersInInterval(int start, int end)
    {
        Random generator = new Random();
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = generator.Next(start, end + 1);
        }

        return nums;
    }
}

