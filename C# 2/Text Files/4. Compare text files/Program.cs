using System;
using System.Linq;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

class Program
{
    static void Main()
    {
        string[] file1 = System.IO.File.ReadAllLines(@"../../input1.txt");
        string[] file2 = System.IO.File.ReadAllLines(@"../../input2.txt");

        int equalLines = file1.Where((line, index) => line == file2[index]).Count();

        Console.WriteLine("Equal lines: " + equalLines);
        Console.WriteLine("Different lines: " + (file2.Length - equalLines));
    }
}