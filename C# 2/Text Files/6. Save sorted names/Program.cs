using System;
using System.Collections;
using System.Linq;
using System.IO;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	output.txt
//Ivan      George
//Peter     Ivan
//Maria     Maria
//George	Peter

class Program
{
    static void Main()
    {
        string[] names = File.ReadAllLines(@"../../names.txt");
        string[] sortedNames = (from name in names
                               orderby name
                               select name).ToArray<string>();
        File.WriteAllLines("../../sorted-names.txt", sortedNames);
        Console.WriteLine("File is written to the project's directory.");
    }
}