using System;
using System.Text;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

class ExtractEMails
{
    static void Main()
    {
        string text = "ooh hi the some text blah blah programming is kewl asdasd@abv.bg yeah .!sadf#!$#asdfasd % <#$>%  ooh another oneee urgitv_ADFG@asd.co.uk";

        Console.WriteLine("Text:");
        Console.WriteLine(text);
        Console.WriteLine("\nEmails:");
        Console.WriteLine(ExtractEmails(text));
    }

    public static string ExtractEmails(string txt)
    {
        Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
        MatchCollection emailMatches = emailRegex.Matches(txt);
        StringBuilder sb = new StringBuilder();

        foreach (Match emailMatch in emailMatches)
        {
            sb.AppendLine(emailMatch.Value);
        }
        return sb.ToString();
    }
}