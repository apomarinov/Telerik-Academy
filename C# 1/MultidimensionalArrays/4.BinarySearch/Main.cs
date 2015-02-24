using System;
using ArrayTools;

//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

class MainClass
{
	static int n, k = 4;
	static int[] arr = {5, 7, 4, 3, 6, 2, 1, 8, 9, 10, 11, 14, 12, 13, 15};
	
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

	static void PrintOutput ()
	{
		Sort.Quick (arr, 0, arr.Length - 1);
		Console.WriteLine (LargestToK ());
	}

	static bool ReadInput ()
	{		
		Console.Write ("Enter n: ");
		if (!int.TryParse (Console.ReadLine (), out n) || n <= 0) {
			return false;
		}
		
		Console.Write ("Enter k: ");
		if (!int.TryParse (Console.ReadLine (), out k)) {
			return false;
		}
		
		arr = new int[n];
		Console.WriteLine ("Enter array: ");
		for (int i = 0; i < n; i++) {
			if (!int.TryParse (Console.ReadLine (), out arr [i])) {
				return false;
			}
		}
		
		return true;
	}
	
	static int LargestToK ()
	{
		int index = Array.BinarySearch (arr, k);
		if (index == 0) {
			return k;
		}
		return arr [index - 1];
	}
}








