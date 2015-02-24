using System;

//Write a method that checks if the element at given position in given array of integers is larger 
//than its two neighbours (when such exist).

class MainClass
{
	static int[] array;
	static int elementIndex;
	
	public static void Main ()
	{
		if (!ReadInput ()) {
			Console.WriteLine ("Invalid Input bro");
			return;
		}
		PrintOutput ();
	}

	static void PrintOutput ()
	{
		Console.WriteLine (LargerThanNeighbours (elementIndex, array));
	}

	static bool ReadInput ()
	{	
		int size;
		Console.Write ("Enter array size: ");
		if (!int.TryParse (Console.ReadLine (), out size) || size <= 0) {
			return false;
		}
		
		Console.Write ("Enter element index: ");
		if (!int.TryParse (Console.ReadLine (), out elementIndex) || elementIndex >= size || elementIndex < 0) {
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
	
	static bool LargerThanNeighbours (int index, int[] arr)
	{
		int largerThanBoth = 0;
		if (index - 1 >= 0 && arr [index] > arr [index - 1]) {
			largerThanBoth++;
		}
		if (index + 1 < arr.Length && arr [index] > arr [index + 1]) {
			largerThanBoth++;
		}
		return largerThanBoth == 2;
	}
	
}












