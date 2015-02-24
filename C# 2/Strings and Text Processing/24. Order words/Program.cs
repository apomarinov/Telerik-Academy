using System;
using System.Collections.Generic;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class Program
{
    static void Main()
    {
        string text = "word aword bword zword Yword Hword Aword iWord";
        string[] allWords = text.Split(' ');
        Array.Sort(allWords);
        Console.WriteLine(string.Join("\n", allWords));
    }
}