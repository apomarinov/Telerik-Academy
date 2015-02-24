using System;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

class MainClass
{
	static int[] array = {1, 2, 3, 100, 3, 4, 5, 55, 23, 2};
	static int startIndex = 4;
	
	public static void Main ()
	{
		// set to false to manually enter input
		bool simulateInput = true;
		if (simulateInput) {
			PrintOutput ();
			return;
		}		
		
		if (!ReadInput ()) {
			Console.WriteLine ("Invalid Input bro");
			return;
		}
		PrintOutput ();
	}
	
	static void PrintOutput ()
	{
		Console.WriteLine (MaxFromIndex (startIndex, array));
	}
	
	static bool ReadInput ()
	{	
		int size;
		Console.Write ("Enter array size: ");
		if (!int.TryParse (Console.ReadLine (), out size) || size <= 0) {
			return false;
		}
		
		Console.Write ("Enter element start index: ");
		if (!int.TryParse (Console.ReadLine (), out startIndex) || startIndex >= size || startIndex < 0) {
			return false;
		}
		
		array = new int[size];
		Console.WriteLine ("Enter array elements: ");
		for (int i = 0; i < size; i++) {
			if (!int.TryParse (Console.ReadLine (), out array [i])) {
				return false;
			}			
		}
		return true;
	}
	
	static int MaxFromIndex (int index, int[] arr)
	{
		int max = arr [index];
		for (int i = index; i < arr.Length; i++) {
			if (max < arr [i]) {
				max = arr [i];
			}
		}
		return max;
	}
	
}












