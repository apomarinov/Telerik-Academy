using System;
using System.Text.RegularExpressions;

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

class Program
{
    static void Main()
    {
        string findWhat = "in";
        string text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine(Regex.Matches(text, findWhat, RegexOptions.IgnoreCase).Count);
    }
}