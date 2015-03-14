using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            FourDigitNumberOperations(2011);
            FourDigitNumberOperations(3333);
            FourDigitNumberOperations(9876);
        }

        static void FourDigitNumberOperations(int num)
        {
            string numStr = num.ToString(),
                   reversed,
                   lastIsFirst,
                   secondIsThird;
            double sum = char.GetNumericValue(numStr[0]) + char.GetNumericValue(numStr[1]) + char.GetNumericValue(numStr[2]) + char.GetNumericValue(numStr[3]);

            Console.WriteLine("Sum: " + sum);

            reversed = numStr[3] + "" + numStr[2] + "" + numStr[1] + "" + numStr[0];
            Console.WriteLine("Reversed: " + reversed);

            lastIsFirst = numStr[3] + "" + numStr[0] + "" + numStr[1] + "" + numStr[2];
            Console.WriteLine("Last is first: " + lastIsFirst);

            secondIsThird = numStr[0] + "" + numStr[2] + "" + numStr[1] + "" + numStr[3];
            Console.WriteLine("Second is third: " + secondIsThird);
        }
    }
}
