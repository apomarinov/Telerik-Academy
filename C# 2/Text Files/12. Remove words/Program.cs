using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

class Program
{
    static void Main()
    {
        try
        {
            string[] wordsToRemove = File.ReadAllLines(@"../../words_to_remove.txt");
            string text = File.ReadAllText(@"../../input.txt");

            foreach (string word in wordsToRemove)
            {
                text = text.Replace(word, string.Empty);
            }

            File.WriteAllText("../../output.txt", text);
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