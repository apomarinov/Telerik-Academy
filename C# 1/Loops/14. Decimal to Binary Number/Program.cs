using System;

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

class Program
{
    static int decimalNumber;

    static void Main()
    {
        ReadInput();
        Console.WriteLine("Binary: " + DecimalToBinary(decimalNumber));
    }

    static void ReadInput()
    {
        Console.Write("Enter decimal number: ");
        int.TryParse(Console.ReadLine(), out decimalNumber);
    }

    static string DecimalToBinary(int decNum)
    {
        string binaryNum = "";
        while (decNum > 0)
        {
            binaryNum += decNum % 2;
            decNum /= 2;
        }
        return ReverseString(binaryNum);
    }

    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }


}