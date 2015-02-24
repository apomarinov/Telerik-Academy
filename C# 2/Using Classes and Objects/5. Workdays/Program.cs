using System;

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

class Program
{
    static void Main()
    {
        DateTime date;

        Console.Write("Enter date in format dd.mm.yyyy: ");
        if(!DateTime.TryParse(Console.ReadLine(), out date)) {
            Console.WriteLine("Invalid input");
            return;
        }    
        if ((date - DateTime.Now).Hours <= 0)
        {
            Console.WriteLine("Enter a future date.");
            return;
        }

        Console.WriteLine("Number of work days starting from tomorrow: " + NumberOfWorkdays(date));
    }

    static int NumberOfWorkdays(DateTime toDate)
    {
        DateTime now = DateTime.Now;
        int workDays = 0;
        
        while((toDate - now).Hours > 0){
            now = now.AddDays(1);
            if (DateIsNotWeekend(now) && DateIsNotHoliday(now))
            {
                workDays++;
            }
        }

        return workDays;
    }

    static bool DateIsNotWeekend(DateTime day)
    {
        return day.DayOfWeek.ToString() != "Saturday" && day.DayOfWeek.ToString() != "Sunday";
    }

    static bool DateIsNotHoliday(DateTime day)
    {
        string[] holidays = { "1.1", "2.1", "3.3", "24.5", "6.9", "24.12", "25.12", "31.12" };
        return Array.IndexOf(holidays, day.Day + "." + day.Month) == -1;
    }
}