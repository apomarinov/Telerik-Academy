using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(BaseXToBaseY("1F4", 16, 10));
    }

    static string BaseXToBaseY(string num, int fromBase, int toBase)
    {
        int decNum = BaseXToDec(num, fromBase);
        return DecToBaseX(decNum, toBase);
    }

    static string DecToBaseX(int dec, int newBase)
    {
        string newNum = "";
        int part = 0;
        char ch;

        for (; dec >= 1; dec /= newBase)
        {
            part = dec % newBase;
            ch = (char) (part >= 10 ? 'A' + part - 10 : '0' + part);
            newNum += ch;
        }

        char[] reverseNewNum = newNum.ToCharArray();
        Array.Reverse(reverseNewNum);
        return new string(reverseNewNum);
    }

    static int BaseXToDec(string num, int oldBase)
    {
        int d = 0;
        int newNum;

        for (int i = num.Length - 1, p = 1; i >= 0; i--, p *= oldBase)
        {
            newNum = (num[i] >= 'A' ? num[i] - 'A' + 10 : num[i] - '0');
            d += newNum * p;
        }

        return d;
    }
}