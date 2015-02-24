using System;

using ArrayTools;
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//	Find in the array those K elements that have maximal sum.

class MainClass
{
	static int[] array = {10, 4, 5, 12, 34, 5, 9, 0, -1, 11};
	static int k = 4;
	
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
		Console.WriteLine (ArrayTo.String (MaxKSumInArray (array)));
	}

	static bool ReadInput ()
	{
		ClearArrayFromExampleData ();
		
		int n;
		Console.Write ("Enter array n: ");
		if (!int.TryParse (Console.ReadLine (), out n) || n <= 0) {
			return false;
		}
		
		Console.Write ("Enter array k: ");
		if (!int.TryParse (Console.ReadLine (), out k) || k <= 0 || k > n) {
			return false;
		}
		
		array = new int[n];
		Console.WriteLine ("Enter array elements: ");
		for (int i = 0; i < n; i++) {
			if (!int.TryParse (Console.ReadLine (), out array [i])) {
				return false;
			}			
		}
		
		return true;
	}
	
	static void ClearArrayFromExampleData ()
	{
		Array.Clear (array, 0, array.Length);	
		k = 0;
	}
	
	// I dont know if this is cheating or not, but when I saw the next problem was sorting an array
	// it occured to me, why dont I first sort this array, and then select the last k numbers :D
	// maybe this is the way to do it, or maybe not but its working :)
	// and I hope I understood the problem right
	static int[] MaxKSumInArray (int[] arr)
	{
		Sort.Selection (arr);
		int[] maxSumElements = new int[k];
		
		int len = arr.Length;
		for (int i = len - k; i < len; i++, k--) {
			maxSumElements [k - 1] = arr [i];
		}
		
		Array.Reverse (maxSumElements);
		return maxSumElements;
	}
}