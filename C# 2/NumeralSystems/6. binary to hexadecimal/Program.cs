using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        Console.Write("Enter binary: ");
        string bin = Console.ReadLine();
        // pad the bits with zeros to a length that is divisible by four without remainder
        bin = PadWithZeros(bin);

        Console.WriteLine("Hexadecimal: " + BinToHex(bin));
    }

    static string PadWithZeros(string str)
    {
        int len = str.Length;
        int lenDivisibleByFour = len;

        while (lenDivisibleByFour % 4 != 0)
        {
            lenDivisibleByFour++;
        }

        return str.PadLeft(lenDivisibleByFour, '0');
    }

    static string BinToHex(string bin)
    {
        string[] bits = Split(bin, 4).ToArray();

        string num = "";
        string part = "";

        for (int i = 0; i < bits.Length; i++)
        {
            switch (bits[i])
            {
                case "0000":
                    part = "0";
                    break;
                case "0001":
                    part = "1";
                    break;
                case "0010":
                    part = "2";
                    break;
                case "0011":
                    part = "3";
                    break;
                case "0100":
                    part = "4";
                    break;
                case "0101":
                    part = "5";
                    break;
                case "0110":
                    part = "6";
                    break;
                case "0111":
                    part = "7";
                    break;
                case "1000":
                    part = "8";
                    break;
                case "1001":
                    part = "9";
                    break;
                case "1010":
                    part = "A";
                    break;
                case "1011":
                    part = "B";
                    break;
                case "1100":
                    part = "C";
                    break;
                case "1101":
                    part = "D";
                    break;
                case "1110":
                    part = "E";
                    break;
                case "1111":
                    part = "F";
                    break;
            }
            num += part;
        }

        return num;
    }

    static IEnumerable<string> Split(string str, int chunkSize)
    {
        return Enumerable.Range(0, str.Length / chunkSize)
            .Select(i => str.Substring(i * chunkSize, chunkSize));
    }
}