using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        private static string companyName;
        private static string companyAddress;
        private static string phoneNumber;
        private static string faxNumber;
        private static string website;
        private static string managerFirstName;
        private static string managerLastName;
        private static string managerPhone;
        private static int    managerAge;

        static void Main(string[] args)
        {
            ReadCompanyInfo();
            PrintCompanyInfo();
        }

        static void ReadCompanyInfo()
        {
            Console.WriteLine("Enter company name:");
            companyName = Console.ReadLine();

            Console.WriteLine("Enter company address:");
            companyAddress = Console.ReadLine();

            Console.WriteLine("Enter phone number:");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter fax number");
            faxNumber = Console.ReadLine();

            Console.WriteLine("Enter website");
            website = Console.ReadLine();

            Console.WriteLine("Enter first name of manager: ");
            managerFirstName = Console.ReadLine();

            Console.WriteLine("Enter last name of manager: ");
            managerLastName = Console.ReadLine();

            Console.WriteLine("Enter manager age: ");
            int.TryParse(Console.ReadLine(), out managerAge);

            Console.WriteLine("Enter manager phone: ");
            managerPhone = Console.ReadLine();
        }

        static void PrintCompanyInfo()
        {
            Console.WriteLine("\n\n" + companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel.: {0}", phoneNumber);
            Console.WriteLine("Web site: {0}", faxNumber);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel.: {3})", managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}
