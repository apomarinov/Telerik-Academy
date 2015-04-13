using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static Dictionary<char, int> base21 = new Dictionary<char, int>();
    static char[] base26 = new char[26];

    static void Main()
    {
        string input = Console.ReadLine();
        //string input = "sgfcg bdgaj fbo";
        //string input = "bdgaj";

        for (int i = 97; i < 118; i++)
        {
            base21[(char)i] = i - 97;   
        }
        for (int i = 0; i < 26; i++)
        {
            base26[i] = (char) (i + 97);
        }

        string[] words = input.Split(' ');
        List<string> decoded = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            decoded.Add(getWord(words[i]));
        }

        Console.WriteLine(string.Join(" ", decoded.ToArray()));
    }

    static string getWord(string w)
    {
        ulong wordToBase21 = 0;
        for (int i = 0, pow = 0; i < w.Length; i++, pow++)
        {
            wordToBase21 *= 21;
            wordToBase21 += (ulong)base21[w[i]];
            //wordToBase21 += (ulong)base21[w[i]] * (ulong)Math.Pow(21, pow);
        }

        StringBuilder sb = new StringBuilder();
        while(wordToBase21 != 0)
        {
            sb.Append(base26[wordToBase21 % 26]);
            wordToBase21 = (wordToBase21 / 26);
        }
        char[] arr = sb.ToString().ToArray();
        Array.Reverse(arr);
        return string.Join("", arr);
    }
}