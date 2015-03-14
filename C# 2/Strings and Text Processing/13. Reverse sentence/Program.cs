using System;

//Write a program that reverses the words in given sentence.
//Example:
//input	                                    output
//C# is not C++ not PHP and not Delphi!	    Delphi not and PHP not C++ not is C#!

class Program
{
    static void Main()
    {
        string sentence = "C# is not C++ not PHP and not Delphi!";

        char sign = sentence[sentence.Length - 1];
        sentence = sentence.Remove(sentence.Length - 1, 1);
        string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        Console.WriteLine("Reversed: " + string.Join(" ", words) + sign);
    }
}