using System;

//Write a method that returns the index of the first element in array 
//that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

class MainClass
{
	static int[] array;

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
		Console.WriteLine ("Index of first larger than neighbours: " + FirstLargerThanNeighbours (array));
	}
	
	static bool ReadInput ()
	{	
		int size;
		Console.Write ("Enter array size: ");
		if (!int.TryParse (Console.ReadLine (), out size) || size <= 0) {
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
	
	static int FirstLargerThanNeighbours (int[] arr)
	{
		for (int i = 0; i < arr.Length; i++) {
			if (LargerThanNeighbours (i, arr)) {
				return i;
			}
		}
		return -1;
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












