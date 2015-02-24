using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        Console.Write("Enter hex: ");
        string hex = Console.ReadLine();

        Console.WriteLine("Decimal: " + HexToDec(hex));
    }

    static int HexToDec(string dec)
    {
        char[] decChars = dec.ToCharArray();
        Array.Reverse(decChars);
        int num = 0;
        int part = 0;

        for (int i = 0; i < decChars.Length; i++)
        {
            if ((int) decChars[i] >= 65)
            {
                switch (decChars[i])
                {
                    case 'A':
                    case 'a':
                        part = 10;
                        break;
                    case 'B':
                    case 'b':
                        part = 11;
                        break;
                    case 'C':
                    case 'c':
                        part = 12;
                        break;
                    case 'D':
                    case 'd':
                        part = 13;
                        break;
                    case 'E':
                    case 'e':
                        part = 14;
                        break;
                    case 'F':
                    case 'f':
                        part = 15;
                        break;
                }
            }
            else
            {
                // subtract the ascii value of 0 to get the ascii value of the given number
                part = (int)decChars[i] - (int)'0';
            }
            
            num += part * (int)Math.Pow(16, i);
        }

        return num;
    }
}