using System;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

class MainClass
{
	static int num;
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
		Console.WriteLine ("Found: " + num + " (" + NumberOccurrenceInArray (num, array) + " times)");
	}

	static bool ReadInput ()
	{
		int size;
		Console.Write ("Enter array size: ");
		if (!int.TryParse (Console.ReadLine (), out size) || size <= 0) {
			return false;
		}
		
		Console.Write ("Enter number to find: ");
		if (!int.TryParse (Console.ReadLine (), out num)) {
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
	
	static int NumberOccurrenceInArray (int n, int[] arr)
	{
		int times = 0;
		for (int i = 0; i < arr.Length; i++) {
			if (arr [i] == n) {
				times++;
			}
		}
		return times;
	}
}





