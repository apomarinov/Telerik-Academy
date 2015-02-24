using System;
using System.Collections.Generic;

//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

class Program
{
    static void Main()
    {
        string text = "word word1 word word2 asd asd asd baba dedo word word2";
        string[] allWords = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> uniqueWords = new Dictionary<string, int>();
        int currentValue;

        foreach (string word in allWords)
        {
            if (!uniqueWords.TryGetValue(word, out currentValue))
            {
                uniqueWords[word] = 1;
            }
            else
            {
                uniqueWords[word] = ++currentValue;
            }
        }

        foreach (var word in uniqueWords)
        {
            Console.WriteLine(word.Key + " -> " + word.Value);
        }
    }
}