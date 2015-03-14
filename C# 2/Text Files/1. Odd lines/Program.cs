using System;
using System.Linq;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

class Program
{
    static void Main()
    {
        string[] allLines = System.IO.File.ReadAllLines(@"../../input.txt");
        string[] oddLines = allLines.Where((line, index) => (index + 1) % 2 != 0).ToArray<string>();
        Console.WriteLine(string.Join("\n", oddLines));
    }
}