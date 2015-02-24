using System;
using System.Text.RegularExpressions;

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//Example:
//input	
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	
//output
//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

class Program
{
    static void Main()
    {
        string text = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        text = ReplaceAnchorTag(text);
        Console.WriteLine(text);
    }

    static string ReplaceAnchorTag(string txt)
    {
        string openingTagRgx = @"<\s*a\s*href\s*=.*?>";
        string closingTagRgx = @"(\<\s*\/\s*a\s*\>)";

        txt = Regex.Replace(txt, openingTagRgx, delegate(Match match)
        {
            string currentMatch = match.ToString();
            // replace <> with []
            currentMatch = Regex.Replace(currentMatch, @"<\s*", "[");
            currentMatch = Regex.Replace(currentMatch, @"\s*=\s*", "=");
            currentMatch = Regex.Replace(currentMatch, @"\s*>", "]");
            // remove quotes and start and end of url
            currentMatch = currentMatch.Replace("\"", String.Empty);
            // replace "a href" with URL
            currentMatch = Regex.Replace(currentMatch, @"(a\s*href\s*)", "URL");
            return currentMatch;
        });

        txt = Regex.Replace(txt, closingTagRgx, delegate(Match match)
        {
            return "[/URL]";
        });

        return txt;
    }
}