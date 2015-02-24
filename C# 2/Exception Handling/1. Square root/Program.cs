using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new ArgumentException("Invalid Number");
            }

            Console.WriteLine(Math.Sqrt(number).ToString("F3"));
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input");
        }
        finally
        {
            Console.WriteLine("Finally");
        }
    }
}