using System;
using System.Net;
using System.Windows.Forms;

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

class Program
{
    static void Main()
    {
        WebClient webClient = new WebClient();

        try
        {
            webClient.DownloadFile("https://telerikacademy.com/Content/Images/news-img01.png",
                "../../logo.jpg");
            Console.WriteLine("Downloaded file saved in the following file system folder:\n" + Application.StartupPath);
        }

        catch (WebException)
        {
            Console.Error.WriteLine("The address is invalid.");
        }

        catch (NotSupportedException)
        {
            Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
        }
    }
}