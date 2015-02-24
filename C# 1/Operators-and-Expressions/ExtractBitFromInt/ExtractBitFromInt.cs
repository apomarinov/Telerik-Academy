using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInt
{
    class ExtractBitFromInt
    {
        static void Main(string[] args)
        {
            ExtractBitAtPos(5, 2);
            ExtractBitAtPos(0, 9);
            ExtractBitAtPos(15, 1);
            ExtractBitAtPos(5343, 7);
            ExtractBitAtPos(62241, 11);
        }

        static void ExtractBitAtPos(int num, int bitPos)
        {
            int mask = 1 << bitPos;
            int numAndMask = num & mask;
            int bit = numAndMask >> bitPos;

            Console.WriteLine(bit);
        }
    }
}
