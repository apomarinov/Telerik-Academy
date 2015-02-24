using System;

//Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input	output
//sample	elpmas

class Program
{
    static void Main()
    {
        Console.Write("Enter string to reverse: ");
        char[] charArray = Console.ReadLine().ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine("Reversed string: " + new string(charArray));
    }
}