using System;
using System.Linq;
using System.IO;

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

class Program
{
    static void Main()
    {
        // this problem is 99% identical to the first problem

        string[] allLines = System.IO.File.ReadAllLines(@"../../input.txt");
        string[] evenLines = allLines.Where((line, index) => (index + 1) % 2 == 0).ToArray<string>();
        Console.WriteLine(string.Join("\n", evenLines));
    }
}