using System;
using ArrayTools;
//Write a program that finds the sequence of maximal sum in given array.

class MainClass
{
	static int[] arr = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
	
	public static void Main ()
	{
		// set to false to manually enter input
		bool simulateInput = true;
		if (simulateInput) {
			PrintOutput ();
			return;
		}

		if (!ReadInput ()) {
			Console.Write ("Invalid Input bro");
			return;
		}
		PrintOutput ();
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
	
	static void PrintOutput ()
	{
		int[] maxSumSequence = FindArraySequence.MaxSum (arr);
		Console.WriteLine ("Sequence: " + ArrayTo.String (maxSumSequence));
		Console.WriteLine ("Sum: " + ValueFromArray.SumOfArray (maxSumSequence));
	}
}