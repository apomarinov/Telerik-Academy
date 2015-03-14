using System;
using System.Linq;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

class Program
{
    static void Main()
    {
        string[] file = System.IO.File.ReadAllLines(@"../../input.txt");
        string[] linesWithNumbers = file.Select((line, index) => (index + 1) + " - " + line ).ToArray<string>();
        System.IO.File.WriteAllLines(@"../../output.txt", linesWithNumbers);
        Console.WriteLine("File is written to the project's directory.");
    }
}