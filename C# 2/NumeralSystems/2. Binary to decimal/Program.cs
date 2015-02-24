using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        Console.Write("Enter binary: ");
        string bin = Console.ReadLine();

        Console.WriteLine("Decimal: " + BinToDec(bin));
    }

    static int BinToDec(string bin)
    {
        int[] bits = bin.Select(c => int.Parse(c.ToString())).ToArray();
        Array.Reverse(bits);
        int num = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            num += bits[i] * (int) Math.Pow(2, i);
        }

        return num;
    }
}