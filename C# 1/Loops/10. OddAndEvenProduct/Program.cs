using System;

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

class Program
{
    static string[] numbers;
    static int oddProduct;
    static int evenProduct;

    static void Main()
    {
        ReadInput();
        PrintResult();
    }

    static void ReadInput()
    {
        Console.Write("Enter nnumbers: ");
        numbers = Console.ReadLine().Split(' ');
    }

    static void PrintResult()
    {
        CalculateOddAndEvenProduct();
        bool equalProducts = oddProduct == evenProduct;

        Console.WriteLine(equalProducts ? "yes" : "no");

        if (equalProducts)
        {
            Console.WriteLine("Product: " + evenProduct);
        }
        else
        {
            Console.WriteLine("Even Product: " + evenProduct);
            Console.WriteLine("Odd Product: " + oddProduct);
        }
    }

    static void CalculateOddAndEvenProduct()
    {
        for (int i = 0, num; i < numbers.Length; i++)
        {
            num = NumberFromString(numbers[i]);

            if ((i + 1) % 2 == 0)
            {
                evenProduct *= num;
            }
            else
            {
                oddProduct *= num;
            }
        }
    }

    static int NumberFromString(string numAsString)
    {
        return int.Parse(numAsString);
    }
}
