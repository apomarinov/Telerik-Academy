using System;
using System.Linq;

//You are given an array of strings. Write a method that sorts the array 
//by the length of its elements (the number of characters composing them).

class MainClass
{
	static int n;
	static string[] arr = {
		"ad",
		"asdfasdf",
		"ads",
		"asdfadsfasdf",
		"asdff",
		"asdf",
		"asdfasd",
		"sdfsdfsdff",
		"asdfasdfasdfadsf"
	};
	
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
		SortByLength ();
		
		Console.WriteLine (string.Join ("\n", arr.Select (v => v.ToString ())));
	}

	static bool ReadInput ()
	{
		Console.Write ("Enter n: ");
		if (!int.TryParse (Console.ReadLine (), out n) || n <= 0) {
			return false;
		}
		
		arr = new string[n];
		Console.WriteLine ("Enter array: ");
		for (int i = 0; i < n; i++) {
			arr [i] = Console.ReadLine ();
		}
		return true;
	}
	
	static void SortByLength ()
	{
		string temp;
		
		for (int i = 0; i < arr.Length; i++) {
			for (int j = 0; j < arr.Length - 1; j++) {
				if (arr [j].Length > arr [j + 1].Length) {
					temp = arr [j + 1];
					arr [j + 1] = arr [j];
					arr [j] = temp;
				}
			}
		}
	}
}







