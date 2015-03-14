using System;
using System.Collections.Generic;
using System.Linq;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

class Program
{
    static void Main()
    {
        // SET TO FALSE TO MANUALLY ENTER INPUT
        bool exampleInput = true;
        string exp;

        if (exampleInput)
        {
            exp = "((a+b)/5-d)";
            Console.WriteLine(exp);
        }
        else
        {
            Console.Write("Enter an expression with brackets: ");
            exp = Console.ReadLine();
        }

        CorrectParentheses(exp);
        Console.WriteLine("Are parentheses correct: " + CorrectParentheses(exp));
    }

    static bool CorrectParentheses(string exp)
    {
        char[] openParentheses = { '(', '[', '{' };
        char[] closeParentheses = { ')', ']', '}' };
        // Indices of the currently open parentheses:
        Stack<int> parentheses = new Stack<int>();

        foreach (char ch in exp)
        {
            int index;

            // get open parentheses indexes
            if ((index = Array.IndexOf(openParentheses, ch)) != -1)
            {
                parentheses.Push(index);
            }
            // compare the last open parenthesis to the next closed one found
            else if ((index = Array.IndexOf(closeParentheses, ch)) != -1)
            {
                if (parentheses.Count == 0 || parentheses.Pop() != index)
                {
                    return false;
                }
            }
        }
        
        return parentheses.Count == 0;
    }
}