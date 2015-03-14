using System;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

class Program
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string tag = "<upcase>", endTag = "</upcase>";
        int length;
        string replaceWhat, replaceWith;

        // loop while you can find the tag
        while (text.IndexOf(tag) != -1)
        {
            // get the length of the first text surround with tags
            // including the tags
            length = text.IndexOf(endTag) + endTag.Length - text.IndexOf(tag);
            //get that substring
            replaceWhat = text.Substring(text.IndexOf(tag), length);
            // remove the start and end tags and make the string upper case
            replaceWith = replaceWhat;
            replaceWith = replaceWith.Replace(tag, "");
            replaceWith = replaceWith.Replace(endTag, "");
            replaceWith = replaceWith.ToUpper();
            // replace the text with the tags with the uppercase text without tags
            text = text.Replace(replaceWhat, replaceWith);
        }

        Console.WriteLine(text);
    }
}