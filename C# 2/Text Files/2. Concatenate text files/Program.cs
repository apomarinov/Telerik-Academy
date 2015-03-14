using System;

//Write a program that concatenates two text files into another text file.

class Program
{
    static void Main()
    {
        string file1 = System.IO.File.ReadAllText(@"../../input1.txt");
        string file2 = System.IO.File.ReadAllText(@"../../input2.txt");
        System.IO.File.WriteAllText(@"../../output.txt", file1 + file2);
        Console.WriteLine("File is written to the project's directory.");
    }
}