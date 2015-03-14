using System;
using System.Text;
using System.Collections.Generic;

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:

//input	                    output
//aaaaabbbbbcdddeeeedssaa	abcdedsa

class Program
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            // add a letter from the original text
            // only if the last one in the new string is not equal to it
            if (i == 0 || i > 0 && sb[sb.Length - 1] != text[i])
            {
                sb.Append(text[i]);
            }
        }

        Console.WriteLine(sb.ToString());
    }
}