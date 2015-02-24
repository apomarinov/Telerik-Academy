using System;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

class Program
{
    static void Main()
    {
        Console.Write("Enter number to format: ");
        int num = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Decimal: {0,15:F}\nHex: {1,15:X}\nPercentage {2,15:P}\nScientific Notation: {3,15:E}", num, num, num, num);
    }
}
