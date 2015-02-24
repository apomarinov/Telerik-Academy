using System;

//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input.Length > 20)
        {
            // use string.replace to replace the symbols from 20 to the end with *
            // first parameter - the substring from the 19th element to the end
            // second parameter - a new string repeated the input`s string length - 20
            Console.WriteLine(input.Replace(input.Substring(19, input.Length - 19), new String('*', input.Length - 20)));
        }
        else
        {
            Console.WriteLine("The string should be more than 20 characters long.");
            return;
        }
    }
}
// qwertyuiopasdfghjklZxcvbnm