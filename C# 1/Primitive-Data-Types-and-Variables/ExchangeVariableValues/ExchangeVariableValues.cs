using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int five = 5,
                ten = 10,
                temp;

            Console.WriteLine("Before: " + five + " and " + ten);

            temp = five;
            five = ten;
            ten = temp;

            Console.WriteLine("After: " + five + " and " + ten);
        }
    }
}
