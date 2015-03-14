using System;

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

class Program
{
    static int decimalNumber;

    static void Main()
    {
        ReadInput();
        Console.WriteLine("Hexadecimal: " + DecimalToHexadecimal(decimalNumber));
    }

    static void ReadInput()
    {
        Console.Write("Enter decimal number: ");
        int.TryParse(Console.ReadLine(), out decimalNumber);
    }

    static string DecimalToHexadecimal(int decNum)
    {
        string hexNum = "";
        while (decNum > 0)
        {
            switch (decNum % 16)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    hexNum += decNum % 16;
                    break;
                case 10:
                    hexNum += "A";
                    break;
                case 11:
                    hexNum += "B";
                    break;
                case 12:
                    hexNum += "C";
                    break;
                case 13:
                    hexNum += "D";
                    break;
                case 14:
                    hexNum += "E";
                    break;
                case 15:
                    hexNum += "F";
                    break;
            }
            decNum /= 16;
        }
        return ReverseString(hexNum);
    }

    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }


}