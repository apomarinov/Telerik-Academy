using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example input:

//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>
//Output:

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.

class Program
{
    static void Main()
    {
        string text = "<html> <head><title>News</title></head> <body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body> </html>";
        Console.WriteLine("Title: " + GetTitle(text));
        Console.WriteLine("Text: " + GetText(text));
    }

    static string GetTitle(string txt)
    {
        string title;
        string titleRgx = @"<title>(.*?)</title>";
        Regex r = new Regex(titleRgx);

        title = r.Match(txt).ToString();
        title = title.Replace("<title>", string.Empty);
        title = title.Replace("</title>", string.Empty);
        return title;
    }

    private static string GetText(string txt)
    {
        string text = Regex.Match(txt, @"<\s*body\s*>.*?<\s*/\s*body\s*>").ToString();
        return Regex.Replace(text, @"<.*?>", String.Empty);
    }

}