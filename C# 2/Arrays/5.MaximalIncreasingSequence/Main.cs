using System;
using System.Collections.Generic;

using ArrayTools;


// Write a program that finds the maximal increasing sequence in an array.
//Example:
//
//input					result
//3, 2, 3, 4, 2, 2, 4		2, 3, 4

class MainClass
{	
	static int[] arr = {3, 2, 3, 4, 2, 2, 4};
	
	public static void Main ()
	{
		// set to false to manually enter input
		bool simulateInput = true;
		if (simulateInput) {
			PrintResult ();
			return;
		}
		
		if (!ReadInput ()) {
			Console.Write ("Invalid Input bro");
			return;
		}
		
		PrintResult ();
	}
	
	static bool ReadInput ()
	{		
		ClearArrayFromExampleData ();
		
		int size;
		Console.Write ("Enter array size: ");
		if (!int.TryParse (Console.ReadLine (), out size) || size <= 0) {
			return false;
		}
		
		arr = new int[size];
		Console.WriteLine ("Enter array elements: ");
		for (int i = 0; i < size; i++) {
			if (!int.TryParse (Console.ReadLine (), out arr [i])) {
				return false;
			}			
		}
		
		return true;
	}
	
	static void ClearArrayFromExampleData ()
	{
		Array.Clear (arr, 0, arr.Length);	
	}
	
	static void PrintResult ()
	{
		Console.WriteLine ("\n" + ArrayTo.String (FindArraySequence.Increasing (arr)));
	}
}







