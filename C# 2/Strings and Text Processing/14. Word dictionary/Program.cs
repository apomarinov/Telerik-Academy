using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add(".NET", "platform for applications from Microsoft");
        dict.Add("CLR", "managed execution environment for .NET");
        dict.Add("namespace", "hierarchical organization of classes");

        Console.WriteLine("Enter a word to search in the dictionary:");
        string input = Console.ReadLine(); 
        string val;
        if (!dict.TryGetValue(input, out val))
        {
            Console.WriteLine("Word doesnt exist in dictinary.");
            return;
        }

        Console.WriteLine(val);
    }
}