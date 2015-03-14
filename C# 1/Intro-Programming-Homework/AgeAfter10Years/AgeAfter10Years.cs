using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            int age;
            DateTime today, birthday;

            today = DateTime.Now;
            birthday = GetBirthday();

            age = today.Year - birthday.Year;
            age = DidHaveBirthday(birthday) ? age : age--;

            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("In 10 years you will be " + (age + 10) + " years old.");
        }

        static DateTime GetBirthday()
        {
            int day, month, year;
            string input;

            Console.WriteLine("Enter year of birth: ");
            input = Console.ReadLine();
            Int32.TryParse(input, out year);

            Console.WriteLine("Enter month of birth: ");
            input = Console.ReadLine();
            Int32.TryParse(input, out month);

            Console.WriteLine("Enter day of birth: ");
            input = Console.ReadLine();
            Int32.TryParse(input, out day);

            return new DateTime(year, month, day);
        }

        static bool DidHaveBirthday(DateTime birthday) {
            DateTime today = DateTime.Now;
            if (today.Month > birthday.Month || today.Month == birthday.Month && today.Day >= birthday.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
