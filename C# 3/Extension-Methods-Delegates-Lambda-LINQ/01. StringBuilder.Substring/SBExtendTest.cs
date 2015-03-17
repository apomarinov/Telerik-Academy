using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StringBuilderExtensions;

//Implement an extension method Substring(int index, int length) for the class StringBuilder
//that returns new StringBuilder and has the same functionality as Substring in the class String.

class SBExtendTest
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello World!");

        Console.WriteLine("String                                : " + sb.ToString());
        Console.WriteLine("Substring from 3rd char               : " + sb.Substring(2));
        Console.WriteLine("Substring from 3rd char with length 3 : " + sb.Substring(2, 3));
    }
}