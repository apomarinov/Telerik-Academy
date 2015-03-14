using System;
using System.Collections.Generic;
using System.Text;

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

class Program
{
    static void Main()
    {
        string text = "text with palindromes: 1234321 ABBA asa baba gaag";
        Console.WriteLine(text + "\n");
        Console.WriteLine("Palindromes: \n" + string.Join("\n", GetPalindromes(text)));
    }

    static string[] GetPalindromes(string txt)
    {
        string[] words = txt.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        List<string> palindromes = new List<string>();

        foreach (var word in words)
        {
            if (word == ReverseWord(word))
            {
                palindromes.Add(word);
            }
        }

        return palindromes.ToArray();
    }

    static string ReverseWord(string word)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            sb.Append(word[i]);
        }

        return sb.ToString();
    }
}