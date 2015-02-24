using System;
using System.Text.RegularExpressions;
using System.IO;

// Modify the solution of the previous problem to replace only whole words (not strings).

class Program
{
    static void Main()
    {
        // same as problem 7, just using a regex for the word
        Regex wordRgx = new Regex("\bstart\b", RegexOptions.IgnoreCase);

        using (StreamReader sr = new StreamReader("../../test.txt"))
        {
            using (StreamWriter sw = new StreamWriter("../../output.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sw.WriteLine(wordRgx.Replace(line, "finish"));
                }
            }
        }
        Console.WriteLine("File is written to the project's directory.");
    }
}