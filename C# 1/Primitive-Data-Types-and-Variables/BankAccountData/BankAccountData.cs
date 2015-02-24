using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Gencho",
                   middleName = "Genchov",
                   lastName = "Genchovski";
            string bankName = "Certified Thiefs",
                   IBAN = "BGUSNDN1864563458634";

            long balance = 9999999;
            int number1, number2, number3;

            Console.WriteLine(firstName + " " + middleName + " " + lastName);
            Console.WriteLine("Has an account at " + bankName);
            Console.WriteLine("His/her IBAN is " + IBAN);
            Console.WriteLine("His/her balance is " + balance);
            Console.WriteLine("His/Her account numbers are: ");
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
        }
    }
}
