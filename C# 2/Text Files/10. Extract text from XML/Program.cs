using System;
using System.Text.RegularExpressions;

//Write a program that extracts from given XML file all the text without the tags.
//Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest>
//<interest>C#</interest><interest>Java</interest></interests></student>

class Program
{
    static void Main()
    {
        string xml = "<?xml version=\"1.0\"><student><name>Pesho</name><age>21</age><interests count=\"3\"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>";

        string match;
        // use a regex to match all text that is surrounded with > and <
        foreach (Match m in Regex.Matches(xml, ">(.*?)<"))
        {
            match = m.Value;
            if (match.Length > 2)
            {
                match = match.Replace(">", String.Empty);
                match = match.Replace("<", String.Empty);
                Console.WriteLine(match);
            } 
        }
    }
}