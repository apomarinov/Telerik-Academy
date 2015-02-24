using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractThirdBit
{
    class ExtractThirdBit
    {
        static void Main(string[] args)
        {
            ExtractBit(5);
            ExtractBit(0);
            ExtractBit(15);
            ExtractBit(5343);
            ExtractBit(62241);
        }

        static void ExtractBit(int num)
        {
            int bitPos = 3;
            int mask = 1 << bitPos;
            int numAndMask = num & mask;
            int bit = numAndMask >> bitPos;

            Console.WriteLine(bit);
        }
    }
}
