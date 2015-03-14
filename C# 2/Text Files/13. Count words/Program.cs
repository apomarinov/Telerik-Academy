using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

class Program
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines("../../words.txt");
            string text = File.ReadAllText("../../test.txt");

            string[] wordsCountOutput = (from w in words                                // select every word in the array
                                         let wordCount = Regex.Matches(text, w).Count   // get its count in the text
                                         orderby wordCount descending                   // order by the count of the word in descending order
                                         select w + " - " + wordCount)                  // construct every line of the output with the word and its count
                                         .ToArray();                                    // convert the query to array

            File.WriteAllText("../../results.txt", string.Join("\n", wordsCountOutput));
            Console.WriteLine("File is written to the project's directory.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("path specified a file that is read-only. -or- This operation is not supported on the current platform. -or- path specified a directory. -or- The caller does not have the required permission.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("path is in an invalid format.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
    }
}