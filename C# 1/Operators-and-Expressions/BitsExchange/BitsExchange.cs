using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            ExchangeBits(1140867093);
            ExchangeBits(255406592);
            ExchangeBits(4294901775);
            ExchangeBits(5351);
            ExchangeBits(2369124121);


        }

        private static long changeBits(long number, int firstposition, int secondPosition)
        {
            number ^= (1 << firstposition);
            return number ^ (1 << secondPosition);
        }

        static void ExchangeBits(uint num)
        {
            int bit3 = GetBitAtPos(num, 3),
                bit4 = GetBitAtPos(num, 4),
                bit5 = GetBitAtPos(num, 5),
                bit24 = GetBitAtPos(num, 24),
                bit25 = GetBitAtPos(num, 25),
                bit26 = GetBitAtPos(num, 26);

            Console.WriteLine("\nBefore num: \t" + num + " \t and bits: " + BinaryFormatedInt(num));

            num = ModifyBitAtPos(num, 24, bit3);
            num = ModifyBitAtPos(num, 25, bit4);
            num = ModifyBitAtPos(num, 26, bit5);
            num = ModifyBitAtPos(num, 3, bit24);
            num = ModifyBitAtPos(num, 4, bit25);
            num = ModifyBitAtPos(num, 5, bit26);

            Console.WriteLine("After num: \t" + num + " \t and bits: " + BinaryFormatedInt(num));
        }

        static string BinaryFormatedInt(uint num)
        {
            return Convert.ToString(num, 2).PadLeft(32, '0').Insert(8, " ").Insert(17, " ").Insert(26, " ");
        }

        static uint ModifyBitAtPos(uint num, int bitPos, int newBit)
        {
            int mask;
            uint result;

            if (newBit == 0)
            {
                mask = ~(1 << bitPos);
                result = (uint) (num & mask);
            }
            else
            {
                mask = newBit << bitPos;
                result = (uint) ((int)num | mask);
            }

            return result;
        }

        static int GetBitAtPos(uint num, int bitPos)
        {
            int mask = 1 << bitPos;
            int numAndMask = (int) (num & mask);
            int bit = numAndMask >> bitPos;

            return bit;
        }
    }
}
