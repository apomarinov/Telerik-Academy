using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBitAtPosition
{
    class ModifyBitAtPosition
    {
        static void Main(string[] args)
        {
            ModifyBit(5, 2, 0);
            ModifyBit(0, 9, 1);
            ModifyBit(15, 1, 1);
            ModifyBit(5343, 7, 0);
            ModifyBit(62241, 11, 0);
        }

        static void ModifyBit(int num, int bitPos, int newBit)
        {
            int mask;
            int result;

            if (newBit == 0)
            {
                mask = ~(1 << bitPos);
                result = num & mask;
            }
            else
            {
                mask = newBit << bitPos;
                result = num | mask;
            }

            Console.WriteLine("Before num: \t" + num + " \t and bits: " + Convert.ToString(num, 2).PadLeft(16, '0').Insert(8, " "));
            Console.WriteLine("After num: \t" + result + " \t and bits: " + Convert.ToString(result, 2).PadLeft(16, '0').Insert(8, " "));
        }
    }
}
