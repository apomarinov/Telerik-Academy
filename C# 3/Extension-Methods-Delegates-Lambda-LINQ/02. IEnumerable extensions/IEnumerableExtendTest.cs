using System;
using IEnumerableExtensions;

//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

class IEnumerableExtendTest
{
    static void Main()
    {
        int[] collection = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, -1};

        Console.WriteLine("Min : " + collection.Min());
        Console.WriteLine("Max : " + collection.Max());
        Console.WriteLine("Sum : " + collection.Sum());
        Console.WriteLine("Avg : " + collection.Average());
        Console.WriteLine("Prod: " + collection.Product());
    }
}