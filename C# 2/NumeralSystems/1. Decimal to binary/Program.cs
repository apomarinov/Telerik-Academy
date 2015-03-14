using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int num;
        Console.Write("Enter number: ");
        int.TryParse(Console.ReadLine(), out num);

        Console.WriteLine("Binary: " + DecToBin(num));
    }

    static string DecToBin(int n)
    {
        List<int> bin = new List<int>();

        while (n >= 1)
        {
            bin.Add(n % 2);
            n /= 2;
        }

        int[] result = bin.ToArray();
        Array.Reverse(result);
        return string.Join("", result.Select(v => v.ToString()));
    }
}