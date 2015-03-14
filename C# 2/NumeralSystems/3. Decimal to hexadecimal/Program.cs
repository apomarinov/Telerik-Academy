using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int num;
        Console.Write("Enter number: ");
        int.TryParse(Console.ReadLine(), out num);

        Console.WriteLine("Hex: " + DecToHex(num));
    }

    static string DecToHex(int n)
    {
        List<char> hex = new List<char>();
        int remainder;
        char addChar = '-';

        while (n >= 1)
        {
            remainder = n % 16;
            if(remainder >= 10) {
                switch(remainder) {
                    case 10:
                        addChar = 'A';
                        break;
                    case 11:
                        addChar = 'B';
                        break;
                    case 12:
                        addChar = 'C';
                        break;
                    case 13:
                        addChar = 'D';
                        break;
                    case 14:
                        addChar = 'E';
                        break;
                    case 15:
                        addChar = 'F';
                        break;
                }
            } else {
                // add the ascii code of 0 to the remainder, so when its cast to char
                // it will be its int value -> 1 = '1'
                addChar = (char)((int)'0' + remainder);
            }
            
            hex.Add(addChar);
            n /= 16;
        }

        char[] result = hex.ToArray();
        Array.Reverse(result);
        return string.Join("", result);
    }
}