using System;
using System.Collections.Generic;

//Write a program that reads a string from the console and prints all different letters
//in the string along with information how many times each letter is found.

class Program
{
    static void Main()
    {
        string text = "jeragjhdfjhadsfhal;adsfkjhasdf";
        Dictionary<char, int> letters = new Dictionary<char, int>();
        int currentValue;

        foreach (char letter in text)
        {
            if (!letters.TryGetValue(letter, out currentValue))
            {
                letters[letter] = 1;
            }
            else
            {
                letters[letter] = ++currentValue;
            }
        }

        foreach (var letter in letters)
        {
            Console.WriteLine(letter.Key + " -> " + letter.Value);
        }
    }
}