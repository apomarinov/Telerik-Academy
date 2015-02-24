using System;
using System.Globalization;
using System.Text;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.


// TO DISPLAY CYRILLIC IN THE CONSOLE CHOOSE THE LUCIDA FONT
// OR CHECK OUT THIS LINK
// http://stackoverflow.com/questions/5055659/c-sharp-unicode-string-output
class Program
{
    static void Main()
    {
        // SET TO FALSE TO MANUALLY ENTER INPUT
        bool exampleInput = true;
        // set the encoding of the console so it can display cyrillic
        Console.OutputEncoding = Encoding.UTF8;
        // make a bulgarian culture object
        CultureInfo culture = new CultureInfo("bg-BG");
        DateTime d;

        if (exampleInput)
        {
            d = DateTime.Now;
        }
        else
        {
            Console.Write("Enter date in format 'day.month.year hour:minute:second': ");
            if (!DateTime.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("Invalid date.");
                return;
            }
        }

        d = d.AddHours(6);
        d = d.AddMinutes(30);

        // user the culture object to get info from the date object in the language passed to the culture object
        Console.WriteLine("Date after 6:30 hours");
        Console.WriteLine("{0:dd.M.yyy H:mm:ss} {1}", d, culture.DateTimeFormat.GetDayName(d.DayOfWeek));
    }
}