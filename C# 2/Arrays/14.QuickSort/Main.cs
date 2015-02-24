using System;
using ArrayTools;

// Write a program that sorts an array of integers using the Quick sort algorithm.

class MainClass
{
	static int[] arr = {1, 4, 5, 61, 123, 9, 234, 2, 22};
	
	public static void Main ()
	{		
		Sort.Quick (arr, 0, arr.Length - 1);
		Console.WriteLine (ArrayTo.String (arr));
	}
}