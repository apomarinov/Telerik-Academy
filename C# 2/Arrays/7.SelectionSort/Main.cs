using System;

using ArrayTools;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//	Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

class MainClass
{
	static int[] arr = {10, 4, 5, 12, 34, 5, 9, 0, 2, 11};
	
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
		Sort.Selection (arr);
		Console.WriteLine (ArrayTo.String (arr));
	}
}