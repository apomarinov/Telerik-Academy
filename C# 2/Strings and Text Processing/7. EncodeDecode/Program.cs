using System;
using System.Text;

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.

class Program
{
    static void Main()
    {
        Console.Write("Enter string to encode: ");
        string input = Console.ReadLine();
        string key = "megagigahiperultrasecurekeyever";

        string[] encoded = Encode(input, key);
        string decoded = Decode(encoded, key);

        Console.WriteLine("Encoded: " + string.Join("", encoded));
        Console.WriteLine("Decoded: " + decoded);
    }

    static string[] Encode(string str, string key)
    {
        string[] encoded = new string[str.Length];

        for (int i = 0, j = 0; i < str.Length; i++, j++)
        {
            if (j == key.Length)
            {
                j = 0;
            }
            encoded[i] = (str[i] ^ key[j]).ToString();
        }

        return encoded;
    }

    static string Decode(string[] encoded, string key)
    {
        StringBuilder decoded = new StringBuilder();

        for (int i = 0, j = 0; i < encoded.Length; i++, j++)
        {
            if (j == key.Length)
            {
                j = 0;
            }
            decoded.Append((char)(int.Parse(encoded[i]) ^ key[j]));
        }

        return decoded.ToString();
    }
}
