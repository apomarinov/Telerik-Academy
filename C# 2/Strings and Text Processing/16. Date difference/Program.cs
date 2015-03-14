using System;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

class Program
{
    static void Main()
    {
        DateTime dateOne, dateTwo;

        Console.Write("Enter date one: ");
        if (!DateTime.TryParse(Console.ReadLine(), out dateOne))
        {
            Console.WriteLine("Invalid date.");
            return;
        }

        Console.Write("Enter date two: ");
        if (!DateTime.TryParse(Console.ReadLine(), out dateTwo))
        {
            Console.WriteLine("Invalid date.");
            return;
        }

        int distance = (dateTwo - dateOne).Days;
        Console.WriteLine("Distance: {0} {1}", distance, distance == 1 ? "day" : "days");
    }
}