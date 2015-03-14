using System;
using System.IO;

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

class Program
{
    static void Main()
    {
        Console.WriteLine("Download the test file 110MB from the link in the comment below, place it in the project's directory and comment out the return below.");
        // link to file: http://goo.gl/rO6MgU
        return;
        using (StreamReader sr = new StreamReader("../../test.txt"))
        {
            using (StreamWriter sw = new StreamWriter("../../output.txt"))
            {
                // for every line the stream reader reads from the file
                // replace start with finish and write it out using the
                // stream writer to the output.txt file
                // this is the first way I did it, and I've tested with a 110MB file
                // and it gets the job done for like 2 seconds on an i5 8GB PC
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sw.WriteLine(line.Replace("start", "finish"));
                }
            }
        }
        Console.WriteLine("File is written to the project's directory.");
    }
}