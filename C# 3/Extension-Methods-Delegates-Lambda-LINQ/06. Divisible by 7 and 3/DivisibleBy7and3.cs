using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

class DivisibleBy7and3
{
    static void Main()
    {
        int[] nums = new int[100];

        for (int i = 0; i < 100; i++)
        {
            nums[i] = i;
        }

        // Extension Methods
        var selectedNums = nums.Where(num => num % 3 == 0 && num % 7 == 0);
        // LINQ
        //var selectedNums = from num in nums
        //                       where num % 3 == 0 && num % 7 == 0
        //                       select num;

        foreach (var num in selectedNums)
        {
            Console.WriteLine(num);
        }
    }
}