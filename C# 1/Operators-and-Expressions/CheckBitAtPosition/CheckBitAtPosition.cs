using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitAtPosition
{
    class CheckBitAtPosition
    {
        static void Main(string[] args)
        {
            CheckBitAtPos(5, 2);
            CheckBitAtPos(0, 9);
            CheckBitAtPos(15, 1);
            CheckBitAtPos(5343, 7);
            CheckBitAtPos(62241, 11);
        }

        static void CheckBitAtPos(int num, int bitPos)
        {
            int mask = 1 << bitPos;
            int numAndMask = num & mask;
            int bit = numAndMask >> bitPos;

            Console.WriteLine(bit == 1);
        }
    }
}
