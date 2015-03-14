using System;

// Write a program that applies bonus score to given score in the range [1…9] by the following rules:
// If the score is between 1 and 3, the program multiplies it by 10.
// If the score is between 4 and 6, the program multiplies it by 100.
// If the score is between 7 and 9, the program multiplies it by 1000.
// If the score is 0 or more than 9, the program prints “invalid score”.

class BonusScore
{
    private static int num;
    private static string result;

    static void Main()
    {
        ReadNumber();
        ApplyScore();
        PrintResult();
    }

    static void ReadNumber()
    {
        Console.Write("Enter number: ");
        int.TryParse(Console.ReadLine(), out num);
    }

    static void ApplyScore()
    {
        if (num <= 0 || num > 9)
        {
            result = "Invalid Score";
        } 
        else if (num >= 1 && num <= 3)
        {
            result = (num * 10).ToString();
        }
        else if (num >= 4 && num <= 6)
        {
            result = (num * 100).ToString();
        }
        else if (num >= 7 && num <= 9)
        {
            result = (num * 1000).ToString();
        }
    }

    static void PrintResult()
    {
        Console.WriteLine(result);
    }
}
