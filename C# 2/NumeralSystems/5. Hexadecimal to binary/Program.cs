using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        Console.Write("Enter hex: ");
        string hex = Console.ReadLine();

        Console.WriteLine("Binary: " + HexToBin(hex));
    }

    static string HexToBin(string dec)
    {
        char[] hexChars = dec.ToCharArray();
        Array.Reverse(hexChars);
        string num = "";
        string part = "";

        for (int i = 0; i < hexChars.Length; i++)
        {
            switch (hexChars[i])
            {
                case '0':
                    part = "0000";
                    break;
                case '1':
                    part = "0001";
                    break;
                case '2':
                    part = "0010";
                    break;
                case '3':
                    part = "0011";
                    break;
                case '4':
                    part = "0100";
                    break;
                case '5':
                    part = "0101";
                    break;
                case '6':
                    part = "0110";
                    break;
                case '7':
                    part = "0111";
                    break;
                case '8':
                    part = "1000";
                    break;
                case '9':
                    part = "1001";
                    break;
                case 'A':
                case 'a':
                    part = "1010";
                    break;
                case 'B':
                case 'b':
                    part = "1011";
                    break;
                case 'C':
                case 'c':
                    part = "1100";
                    break;
                case 'D':
                case 'd':
                    part = "1101";
                    break;
                case 'E':
                case 'e':
                    part = "1110";
                    break;
                case 'F':
                case 'f':
                    part = "1111";
                    break;
            }

            num += part;
        }

        return num;
    }
}