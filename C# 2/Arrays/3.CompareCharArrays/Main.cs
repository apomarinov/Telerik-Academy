using System;

// Write a program that compares two char arrays lexicographically (letter by letter).

class MainClass
{
	static char[] arr1, arr2;
	static bool simulateInput;
	
	public static void Main ()
	{
		// set to false to manually enter input
		simulateInput = true;
		
		if (simulateInput) {
			ExampleInput ();
			return;
		}
		
		if (!ReadInput ()) {
			Console.Write ("Invalid Input bro");
			return;
		}
		Console.WriteLine ("Equal: " + CompareCharArrays (arr1, arr2));
	}
	
	static void ExampleInput ()
	{
		arr1 = new char[2];
		arr2 = new char[2];
		
		arr1 [0] = 'a';
		arr1 [1] = 'a';
		
		arr2 [0] = 'a';
		arr2 [1] = 'a';
		Console.WriteLine ("Equal: " + CompareCharArrays (arr1, arr2));
		
		arr1 [0] = 'a';
		arr1 [1] = 'a';
		
		arr2 [0] = 'a';
		arr2 [1] = 'b';
		Console.WriteLine ("Equal: " + CompareCharArrays (arr1, arr2));
	}
	
	static bool ReadInput ()
	{
		int size;
		
		Console.Write ("Enter array size: ");
		if (!int.TryParse (Console.ReadLine (), out size) || size <= 0) {
			return false;
		}
		
		arr1 = new char[size];
		arr2 = new char[size];

		string input;
		Console.WriteLine ("Enter first array: ");
		for (int i = 0; i < size; i++) {
			input = Console.ReadLine ();
			if (input.Length > 1) {
				return false;
			}
			arr1 [i] = input [0];
		}
		
		Console.WriteLine ("Enter second array: ");
		for (int i = 0; i < size; i++) {
			input = Console.ReadLine ();
			if (input.Length > 1) {
				return false;
			}
			arr2 [i] = input [0];
		}
		
		return true;
	}
	
	static bool CompareCharArrays (char[] arrOne, char[] arrTwo)
	{
		int length = arrOne.Length;
		
		if (length != arrTwo.Length) {
			return false;
		}
		
		for (int i = 0; i < length; i++) {
			if (arrOne [i] != arrTwo [i]) {
				return false;
			}
		}
		
		return true;
	}
}