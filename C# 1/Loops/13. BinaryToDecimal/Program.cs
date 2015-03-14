using System;

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

class Program
{
    static string binaryNumberAsString;

    static void Main()
    {
        ReadBinaryNumberAsString();
        PrintResult();
    }

    static void ReadBinaryNumberAsString()
    {
        Console.Write("Enter binary number: ");
        binaryNumberAsString = Console.ReadLine();
    }

    static void PrintResult()
    {
        Console.WriteLine("Decimal: " + BinaryToDecimal(binaryNumberAsString));
    }

    static long BinaryToDecimal(string binary)
    {
        long decimalNumber = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            decimalNumber += (long.Parse(binary[binary.Length - 1 - i].ToString())) * (long)Math.Pow(2, i);
        }

        return decimalNumber;
    }
}