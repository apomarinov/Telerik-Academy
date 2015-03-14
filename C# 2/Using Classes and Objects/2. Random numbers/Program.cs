using System;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

class Program
{
    static void Main()
    {
        int i = 0;
        Random randGen = new Random();

        while (i++ < 10)
        {
            Console.WriteLine(randGen.Next(100, 200));
        }
    }
}