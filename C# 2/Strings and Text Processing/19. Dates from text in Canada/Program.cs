using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

class Program
{
    static void Main()
    {
        string text = "tex text asd asd as da sda sd  kajdfgkjdfg 10.11.2002. dfng akdgafg 22.03.1999";

        Console.WriteLine("text: ");
        Console.WriteLine(text);

        string[] foundDates = DatesFromText(text);

        Console.WriteLine("Dates: \n" + string.Join("\n", foundDates));

        Console.WriteLine("\nDates in canadian format: \n" + string.Join("\n", CanadianDates(foundDates)));
    }

    static string[] DatesFromText(string txt)
    {
        List<string> dates = new List<string>();

        foreach (Match date in Regex.Matches(txt, @"[0-9]{2}.[0-9]{2}.[0-9]{4}"))
        {
            dates.Add(date.Value);
        }

        return dates.ToArray();
    }

    static string[] CanadianDates(string[] dates)
    {
        List<string> canadianDates = new List<string>();
        DateTime d;

        foreach (string date in dates)
        {
            if (DateTime.TryParse(date, out d))
            {
                canadianDates.Add(d.ToString("yyyy-MM-dd"));
            }
        }

        return canadianDates.ToArray();
    }
}