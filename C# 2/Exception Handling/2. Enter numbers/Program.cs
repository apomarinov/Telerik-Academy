using System;

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

class Program
{
    static void Main()
    {
        int start = -10;
        int end = 20;

        Console.WriteLine("Enter numbers from " + start + " to " + end);
        for (int i = 0; i < 10; i++)
        {
            try
            {
                int newNumber = ReadNumber(start, end);
            }
            catch (ArgumentOutOfRangeException or)
            {
                Console.WriteLine(or.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }
    }

    static int ReadNumber(int start, int end)
    {
        int num = 0;

        if (start > end)
        {
            num = start;
            start = end;
            end = num;
            num = 0;
        }

        try
        {
            num = int.Parse(Console.ReadLine());
            if (num < start || num > end)
            {
                throw new ArgumentOutOfRangeException();
            }

            return num;
        }
        catch (FormatException fe)
        {
            throw new FormatException("Invalid Input", fe);
        }
    }
}