using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            CanDevideBy7And5(3);
            CanDevideBy7And5(0);
            CanDevideBy7And5(5);
            CanDevideBy7And5(7);
            CanDevideBy7And5(35);
            CanDevideBy7And5(140);
        }

        static void CanDevideBy7And5(int num)
        {
            Console.WriteLine(num + ": " + (num % 7 == 0 && num % 5 == 0 && num != 0));
        }
    }
}
