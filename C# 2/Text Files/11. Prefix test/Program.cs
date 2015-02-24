using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

class Program
{
    static void Main()
    {
        string[] allLines = File.ReadAllLines(@"../../input.txt");
        string[] noTestWords = allLines.Where(line => !Regex.IsMatch(line, @"\btest([a-zA-Z0-9_]*)\b")).ToArray<string>();
        File.WriteAllLines("../../output.txt", noTestWords);
        Console.WriteLine("File is written to the project's directory.");
    }
}