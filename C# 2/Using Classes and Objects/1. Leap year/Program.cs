using System;

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

class Program
{
    static void Main()
    {
        int year;
        Console.Write("Enter year: ");
        int.TryParse(Console.ReadLine(), out year);

        Console.WriteLine("{0} {1} a leap year", year, DateTime.IsLeapYear(year) ? "is" : "is not");
    }
}