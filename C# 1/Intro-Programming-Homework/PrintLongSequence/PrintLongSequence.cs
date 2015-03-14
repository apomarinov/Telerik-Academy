using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1002; i++)
            {
                bool addMinus = i % 2 != 0 ? true : false;
                Console.WriteLine(i * (addMinus ? -1 : 1));
            }
        }
    }
}
