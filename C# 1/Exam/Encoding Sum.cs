using System;

class Program
{
    static void Main()
    {
        ushort m = ushort.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        int RESULT = 0;
        char ch;

        for (int i = 0, letterCode; i < text.Length; i++)
        {
            ch = text[i];
            if (ch == '@')
            {
                Console.Write(RESULT);
                return;
            }
            if (IsDigit(ch))
            {
                RESULT *= short.Parse(ch.ToString());
                continue;
            }
            letterCode = IsLetter(ch);
            if (letterCode != 0)
            {
                RESULT += LetterIndexInAlphabet(letterCode);
                continue;
            }
            RESULT %= m;
        }
    }

    static bool IsDigit(char ch)
    {
        int code = (int) ch;
        return (code > 47 && code < 58);
    }

    static int IsLetter(char ch)
    {
        int code = (int)ch;
        if (code > 64 && code < 91 || code > 96 && code < 123)
        {
            return code;
        }
        return 0;
    }

    static int LetterIndexInAlphabet(int code)
    {
        if (code > 64 && code < 91)
        {
            return code - 65;
        } 
        else if(code > 96 && code < 123)
        {
            return code - 97;
        }
        return 0;
    }
}