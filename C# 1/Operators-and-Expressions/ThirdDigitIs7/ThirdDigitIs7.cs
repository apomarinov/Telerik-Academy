using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            ThirdDigit7(5);
            ThirdDigit7(701);
        }

        static void ThirdDigit7(int num)
        {
            string numStr = num.ToString();
            if (numStr.Length >= 3)
            {
                Console.WriteLine(numStr[numStr.Length - 3] == '7');
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
