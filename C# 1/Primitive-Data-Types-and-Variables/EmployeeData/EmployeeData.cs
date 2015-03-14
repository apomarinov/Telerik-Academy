using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Pencho",
                   lastName = "Penchovski";
            byte age = 22;
            char gender = 'M';
            long personalID = 8306112507;
            int uniqueEmployeeNumber = 27569999;

            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID Number: " + personalID);
            Console.WriteLine("Unique Employee Number: " + uniqueEmployeeNumber);
        }
    }
}
