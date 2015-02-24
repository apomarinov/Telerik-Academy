using System;

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//input	   output
//Hi!	   \u0048\u0069\u0021

class Program
{
    static void Main()
    {
        Console.Write("Enter word: ");
        string input = Console.ReadLine();

        Console.WriteLine();
        for (int i = 0, ch; i < input.Length; i++)
        {
            ch = input[i];
            Console.Write("\\" + ch.ToString("X").PadLeft(4, '0'));
        }
        Console.WriteLine();
    }
}