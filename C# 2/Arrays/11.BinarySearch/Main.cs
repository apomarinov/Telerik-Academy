using System;

using ArrayTools;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//	Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

class MainClass
{
	static int[] arr = {1, 20, 3, -1, 2, 6, 11, 12};
	static int numToFind = 11;
	
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
		
		Console.Write ("Enter number to find: ");
		if (!int.TryParse (Console.ReadLine (), out numToFind)) {
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
		int[] startArray = (int[])arr.Clone ();
		Sort.Selection (arr);
		int[] binarySearchResult = Search.Binary (numToFind, arr);
		
		int foundAtIndex = binarySearchResult [0];
		int operations = binarySearchResult [1];
		
		Console.WriteLine ("Start array:  " + ArrayTo.String (startArray));
		Console.WriteLine ("Sorted array: " + ArrayTo.String (arr));
		if (binarySearchResult [0] == -1) {
			Console.WriteLine ("Not Found");
			return;
		}
		Console.WriteLine ("Found " + numToFind + " at index " + foundAtIndex + " with " + operations + (operations == 1 ? " operation." : " operations."));
	}
}