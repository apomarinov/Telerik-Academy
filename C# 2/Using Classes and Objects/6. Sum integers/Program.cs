using System;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:

//input	            output
//"43 68 9 23 318"	461

class Program
{
    static void Main()
    {
        string numbers;

        Console.WriteLine("Enter numbers separated by an interval: ");
        numbers = Console.ReadLine();

        if (numbers.Split(' ').Length == 1)
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        Console.WriteLine("Sum: " + SumArrayNumbers(numbers.Split(' ')));
    }

    static int SumArrayNumbers(string[] nums)
    {
        int sum = 0;
        int num;

        for (int i = 0; i < nums.Length; i++)
        {
            if (int.TryParse(nums[i], out num))
            {
                sum += num;
            }
        }

        return sum;
    }
}