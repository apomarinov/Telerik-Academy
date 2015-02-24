using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            IsOdd(3);
            IsOdd(2);
            IsOdd(-2);
            IsOdd(-1);
            IsOdd(0);
        }

        static void IsOdd(int num)
        {
            Console.WriteLine(num + ": " + (num % 2 != 0));
        }
    }
}
