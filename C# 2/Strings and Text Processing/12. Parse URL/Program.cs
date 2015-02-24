using System;
using System.Collections.Generic;

//Write a program that parses an URL address given in the format: 
//[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:

//URL	Information
//http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
//[server] = telerikacademy.com 
//[resource] = /Courses/Courses/Details/212

class Program
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        List<string> urlParts = new List<string>();
        urlParts.AddRange(url.Split('/'));
        
        string protocol = urlParts[0].Split(':')[0];
        string server = urlParts[2];
        string resource = "/" + string.Join("/", urlParts.GetRange(3, urlParts.Count - 3));

        Console.WriteLine("Protocol: " + protocol);
        Console.WriteLine("Server:   " + server);
        Console.WriteLine("Resource: " + resource);
    }
}
